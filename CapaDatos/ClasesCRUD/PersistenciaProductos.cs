using System;
using System.Collections.Generic;
using System.Linq;
using CapaDatos.Modelos;

namespace CapaDatos.ClasesCRUD
{
    public static class PersistenciaProductos
    {

        public static List<Producto> ListaProductos { get; set; }

        /// <summary>
        /// Método para crear productos aleatoreamente.
        /// </summary>
        public static void CrearProductos()
        {
            Random random = new Random();
            int numero;
            for (int i = 1; i <= 10; i++)
            {

                Producto producto = new Producto();
                producto.Identificador = i;
                numero = random.Next(20);
                char letra = (char)(((int)'A') + random.Next(26));
                producto.Descripcion = "PRODUCTO" + letra + numero + i;
                producto.Precio = numero;

                Random existencia = new Random();
                producto.Existencia = random.Next(100);
                ListaProductos.Add(producto);

                //Modificar el método para agregar categorías aleatoreas
            }
        }

        //CRUD
        //CREATE
        public static void GuardarProducto(Producto producto)
        {
            ListaProductos.Add(producto);
        }

        //UPDATE
        public static void ModificarProducto(int identificador, string descripcion, string categoria)
        {
            Producto producto = ListaProductos.Find(x => x.Identificador == identificador);
            producto.Descripcion = descripcion;
            producto.Categoria = categoria;
        }

        //DELETE
        public static void EliminarProducto(int identificador)
        {
            ListaProductos.RemoveAll(producto => producto.Identificador == identificador);
        }

        //READ
        //UN OBJETO
        public static Producto BuscarProducto(int identificador)
        {

            return ListaProductos.Find(producto => producto.Identificador == identificador);
        }

        //LISTADO DE OBJETOS FORMATEADOS SEGÚN REQUERIMIENTO
        public static string RetornarProductosEnString()
        {
            return ListaProductos.Aggregate("", (acumulador, producto) => acumulador += $"{producto.Identificador} \t\t\t {producto.Descripcion} \t\t\t {producto.Precio} \t {producto.Existencia}\n");
        }

        public static string OrdenarProductos()
        {
            var Ordenar = ListaProductos.OrderBy(orden => orden.Precio).Select(ver => $"{ver.Identificador} \t\t\t{ver.Descripcion} \t\t\t {ver.Precio} \t");
            return string.Join("\n", Ordenar);
        }

       public static string ExistenciaProducto(int id)
        {
            var existe = ListaProductos.Where(producto => producto.Identificador == id).Select(exi => exi.Existencia);
            
            return string.Join(" ",existe);
        }

        public static string ProductoPrecioBajo()
        {
            var bajo = ListaProductos.OrderBy(producto => producto.Precio).Select(ver => $" El Producto {ver.Descripcion} tiene el mas bajo precio de: {ver.Precio}\t ").First();
            return string.Join(" ",bajo);
        }

        public static string PromedioPrecioProducto()
        {

            return string.Join(" ", ListaProductos.Average(promedio => promedio.Precio));
        }

        public static string ListaMayorUsarioPrecio(decimal valor)
        {
            
            return string.Join(" ", ListaProductos.Where(m => m.Precio > valor).OrderByDescending(m => m.Precio).Select(ver => $"{ ver.Descripcion}\t {ver.Precio}\n"));
        }

    }
}
