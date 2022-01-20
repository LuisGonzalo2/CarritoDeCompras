using System;
using System.Collections.Generic;
using CapaDatos.Modelos;

namespace CapaDatos.ClasesCRUD
{
    public class GestionProductos
    {
        public GestionProductos()
        {
            this.ListaStockProductos = new List<Producto>();
        }

       public List<Producto> ListaStockProductos { get; set; }

        public void CrearProductos()
        {
            Random random = new Random();
            int numero;
            for (int i = 1; i <= 10; i++)
            {
               
                Producto producto = new Producto();
                producto.Identificador = i;
                numero = random.Next(20);
                char letra = (char)(((int)'A') + random.Next(26));
                producto.Descripcion = "PRODUCTO" +letra + numero + i;                
                producto.Precio = numero;

                Random existencia = new Random();
                producto.Existencia = existencia.Next(100);
                this.ListaStockProductos.Add(producto);
           }
       }

        //Modificar este método
       public void ImprimirStockProductos()
       {
           Console.WriteLine("Stock de Productos");
           Console.WriteLine("Identificador\tDescripción\tPrecio");
           foreach (var item in this.ListaStockProductos)
           {
                   Console.WriteLine("{0}\t\t{1}\t{2}",
                   item.Identificador, item.Descripcion, item.Precio, item.Existencia);

            }
        }

        //Añadir método que permita la búsqueda de un producto del stock de productos y devuelva ese producto.
        //Añadir método que devuelva la cantidad de productos (stock total) que hay en el local por medio de ListaStockProductos.
        //Añadir método que devuelva el producto cuyo precio sea el mas alto.

    }
}
