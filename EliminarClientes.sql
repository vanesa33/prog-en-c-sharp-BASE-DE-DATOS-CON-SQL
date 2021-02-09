create procedure EliminarClientes

@id_cli int

as

delete from Cliente where id_clientes=@id_cli

