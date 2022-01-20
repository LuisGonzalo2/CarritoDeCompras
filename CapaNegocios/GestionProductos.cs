using System;
using System.Collections.Generic;
using CapaDatos.ClasesCRUD;
using CapaDatos.Modelos;

namespace CapaNegocios
{
    public class GestionProductos
    {
        public GestionProductos()
        {
            PersistenciaProductos.ListaProductos = new List<Producto>();
            PersistenciaProductos.CrearProductos();
        }

        public void GuardarProducto(int identificador, string descripcion, decimal precio, int existencia, string categoria)
        {
            PersistenciaProductos.GuardarProducto(new Producto(identificador, descripcion, precio, existencia, categoria));
        }

        public string ListarProductos()
        {
            return "ID\t\t\tDESCRIPCION\t\t\tPRECIO\tEXISTENCIA\n" + PersistenciaProductos.RetornarProductosEnString();
        }

        public string existencia(int valor)
        {
            return PersistenciaProductos.ExistenciaProducto(valor);
        }
        public string ProductosOrdenados()
        {
            return "ID\t\t\tDESCRIPCION\t\t\tPRECIO\n"+ PersistenciaProductos.OrdenarProductos();
        }
        public string ProductoBajo()
        {
            return PersistenciaProductos.ProductoPrecioBajo();
        }

        public string PromedioProductos()
        {
            return PersistenciaProductos.PromedioPrecioProducto();
        }

        public string ListaPrecioCliente(decimal valor)
        {
           return PersistenciaProductos.ListaMayorUsarioPrecio(valor);
        }
    }
}
