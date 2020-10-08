USE [ORBIPE]
GO

/****** Object: SqlProcedure [Dashboard].[UspGetDashboardITLAJVMateria] Script Date: 10/8/2020 3:00:16 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Dashboard].UspGetDashboardITLAJVMateria
as
SELECT UPPER(m.descripcion) AS [Materia], count(1) AS Cantidad  FROM Admin.Solicitud s (nolock) 
INNER JOIN [Admin].[ProyectoEspecialMateriaGrupo] PEMG ON s.ProyectoEspecialMateriaGrupoID = PEMG.ProyectoEspecialMateriaGrupoID
INNER JOIN ORBI.dbo.Materia m ON M.IDmateria = PEMG.idMateria
GROUP BY m.descripcion
ORDER BY 2 desc
