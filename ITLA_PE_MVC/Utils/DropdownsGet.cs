//using ITLA_PE_MVC.Services;
using ITLA_PE_MVC.SERVICE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using ITLA_PE_MVC.ENTITY;

namespace ITLA_PE_MVC.Utils
{
    public class DropdownsGet
    {
        private Utils util = new Utils();
        private ServicesRequest serv = new ServicesRequest();
        public List<SelectListItem> getProvincias()
        {
            List<SelectListItem> _data = new List<SelectListItem>();

            var lista = serv.GetProvinciasRD().ToList();
            foreach (var item in lista)
            {
                _data.Add(new SelectListItem
                {
                    Text = item.ProvinciaNombre,
                    Value = item.IDprovincia.ToString()
                });
            }
            return _data;
        }

        public List<SelectListItem> getIdentificationType()
        {
            List<SelectListItem> _data = new List<SelectListItem>();

            var lista = serv.GenericItems("TipoIdentificacion").ToList();
            foreach (var item in lista)
            {
                _data.Add(new SelectListItem
                {
                    Text = util.repairString(item.GenericDescription),
                    Value = item.GenericID.ToString()
                });
            }
            return _data;
        }
        public List<SelectListItem> getIngresoFamiliar()
        {
            List<SelectListItem> _data = new List<SelectListItem>();

            var lista = serv.GenericItems("IngresoFamiliar").ToList();
            foreach (var item in lista)
            {
                _data.Add(new SelectListItem
                {
                    Text = item.GenericDescription,
                    Value = item.GenericID.ToString()
                });
            }
            return _data;
        }
        

        public List<SelectListItem> getAcademicLevel()
        {
            List<SelectListItem> _data = new List<SelectListItem>();

            var lista = serv.GenericItems("NivelAcademico").ToList();
            foreach (var item in lista)
            {
                _data.Add(new SelectListItem
                {
                    Text = util.repairString(item.GenericDescription),
                    Value = item.GenericID.ToString()
                });
            }
            return _data;
        }

        public List<SelectListItem> getCarreras()
        {
            List<SelectListItem> _data = new List<SelectListItem>();

            var lista = serv.GetCarreras().ToList();
            foreach (var item in lista)
            {
                _data.Add(new SelectListItem
                {
                    Text = item.Carrera,
                    Value = item.IDcarrera.ToString()
                });
            }
            return _data;
        }

        public List<SelectListItem> getTrueFalse()
        {
            List<SelectListItem> _data = new List<SelectListItem>();
            List<UspGenericItems_Result> lista = new List<UspGenericItems_Result>();
            lista.Add(
                new UspGenericItems_Result
                {
                    GenericID = 0,
                    GenericDescription = "NO"
                }
            );
            lista.Add(
                new UspGenericItems_Result
                {
                    GenericID = 1,
                    GenericDescription = "SI"
                }
            );

            foreach (var item in lista)
            {
                _data.Add(new SelectListItem
                {
                    Text = util.repairString(item.GenericDescription),
                    Value = item.GenericID.ToString()
                });
            }
            return _data;
        }


        public List<SelectListItem> getAssigmentsAviable()
        {
            List<SelectListItem> _data = new List<SelectListItem>();
            var lista = serv.GetMateriasDisponibles().ToList();
            foreach (var item in lista)
            {
                _data.Add(new SelectListItem
                {
                    Text = item.Materia,
                    Value = item.ProyectoEspecialMateriaGrupoID.ToString()
                }); ;
            }
            return _data;
        }



        public List<SelectListItem> getMuncicipiesDrop(int ProvinciaId)
        {
            List<SelectListItem> lista = new List<SelectListItem>();
            var municipies = serv.GetMunicipiosPorProvincia(ProvinciaId).ToList();
            foreach (var item in municipies)
            {
                lista.Add(new SelectListItem
                {
                    Text = item.Municipio,
                    Value = item.IDmunicipio.ToString()
                }); ;
            }
            return lista;
        }

        public List<UspMunicipiosPorProvincia_Result> getMuncicipies(int ProvinciaId)
        {
            List<UspMunicipiosPorProvincia_Result> lista = new List<UspMunicipiosPorProvincia_Result>();
            var municipies = serv.GetMunicipiosPorProvincia(ProvinciaId).ToList();
            foreach (var item in municipies)
            {
                lista.Add(new UspMunicipiosPorProvincia_Result
                {
                    Municipio = item.Municipio,
                    IDmunicipio = item.IDmunicipio
                });
            }

            return municipies;

        }


}
}









