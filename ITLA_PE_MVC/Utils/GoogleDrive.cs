using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace ITLA_PE_MVC.Utils
{
    public class GoogleDrive
    {
        private UserCredential credential;
        private static string[] Scopes = { DriveService.Scope.Drive };
        private static string ApplicationName = "ITLAPE";
        private DriveService driveService;

        /// <summary>
        ///
        /// </summary>
        /// <param name="credentialsFile"></param>
        public GoogleDrive(string credentialsFile, string tokenJSONFile)
        {
            using (var stream =
                new FileStream(credentialsFile, FileMode.Open, FileAccess.Read))
            {
                //string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "admin",
                    CancellationToken.None,
                                        //new FileDataStore("Drive.Api.Auth.Store")
                                        new FileDataStore(tokenJSONFile, true)

                    ).Result;
                // Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Drive API service.
            driveService = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="folderId"></param>
        /// <returns></returns>
        public Google.Apis.Drive.v3.Data.File CreateFolder(string name, string folderId = null)
        {
            var fileMetadata = new Google.Apis.Drive.v3.Data.File()
            {
                Name = name,
                MimeType = "application/vnd.google-apps.folder"
            };

            if (!string.IsNullOrEmpty(folderId))
            {
                fileMetadata.Parents = new List<string> { folderId };
            }
            var request = this.driveService.Files.Create(fileMetadata);
            var folder = request.Execute();
            return folder;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="driveService"></param>
        /// <param name="fields"></param>
        /// <returns></returns>
        public IList<Google.Apis.Drive.v3.Data.File> GetFiles(string fields = "id, name, parents, webContentLink, mimeType")
        {
            IList<Google.Apis.Drive.v3.Data.File> files = new List<Google.Apis.Drive.v3.Data.File>();
            // Define parameters of request.
            FilesResource.ListRequest listRequest = this.driveService.Files.List();
            listRequest.PageSize = 999999999;
            listRequest.Fields = string.Format("nextPageToken, files({0})", fields);

            // List files.
            files = listRequest.Execute()
                .Files;

            return files;
        }

        public void ShareableFileById(string fileId)
        {
            Permission domainPermission = new Permission()
            {
                Type = "anyone",
                Role = "reader"
            };

            this.driveService.Permissions.Create(domainPermission, fileId).Execute();
        }

        public IList<Google.Apis.Drive.v3.Data.File> GetFolder(string folderName, string parentId = "", string fields = "id, name, parents, webContentLink, mimeType")
        {
            IList<Google.Apis.Drive.v3.Data.File> files = new List<Google.Apis.Drive.v3.Data.File>();
            // Define parameters of request.
            FilesResource.ListRequest listRequest = this.driveService.Files.List();
            if (string.IsNullOrEmpty(parentId))
            {
                listRequest.Q = "mimeType='application/vnd.google-apps.folder' and name='" + folderName + "'";
            }
            else
            {
                listRequest.Q = "mimeType='application/vnd.google-apps.folder' and name='" + folderName + "' and '" + parentId + "' in parents";
            }
            listRequest.PageSize = 1000;
            listRequest.Fields = string.Format("nextPageToken, files({0})", fields);

            // List files.
            files = listRequest.Execute()
                .Files;

            return files;
        }

        public IList<Google.Apis.Drive.v3.Data.File> GetFilesByFolderId(string parentId, string fields = "id, name, parents, webContentLink, mimeType, webViewLink, trashed")
        {
            IList<Google.Apis.Drive.v3.Data.File> files = new List<Google.Apis.Drive.v3.Data.File>();
            // Define parameters of request.
            FilesResource.ListRequest listRequest = this.driveService.Files.List();

            listRequest.Q = "'" + parentId + "' in parents";

            listRequest.PageSize = 1000;
            listRequest.Fields = string.Format("nextPageToken, files({0})", fields);

            // List files.
            files = listRequest.Execute()
                .Files;

            return files;
        }

        public void DeleteFile(string id)
        {
            this.driveService.Files.Delete(id).Execute();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="filePath"></param>
        /// <param name="contentType"></param>
        /// <param name="folderId"></param>
        /// <returns></returns>
        public Google.Apis.Drive.v3.Data.File UploadFile(string fileName, string filePath, string contentType, string folderId = null)
        {
            var fileMetadata = new Google.Apis.Drive.v3.Data.File()
            {
                Name = fileName
            };

            if (!string.IsNullOrEmpty(folderId))
            {
                fileMetadata.Parents = new List<string> { folderId };
            }

            FilesResource.CreateMediaUpload request;
            using (var stream = new System.IO.FileStream(filePath,
                System.IO.FileMode.Open))
            {
                request = this.driveService.Files.Create(
                    fileMetadata, stream, contentType);
                request.Upload();
            }

            var file = request.ResponseBody;
            return file;
        }
    }
}