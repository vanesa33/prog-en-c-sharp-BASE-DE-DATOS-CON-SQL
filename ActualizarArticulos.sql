USE [Administracion]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarArticulos]    Script Date: 23/1/2021 19:50:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[ActualizarArticulos]

@id_pro int, @Nom_pro varchar(100), @precio float

as

--actualiza articulos

if not exists (select id_pro from Articulo where id_pro=@id_pro)

insert into Articulo (id_pro, Nom_pro, Precio) values (@id_pro, @Nom_pro, @precio)

--si existe que actualice el campo

else

update Articulo set id_pro=@id_pro, Nom_pro=@Nom_pro, Precio= @precio where id_pro = @id_pro

