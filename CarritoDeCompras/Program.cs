using System;
using System.Linq;
using CapaNegocios;

namespace CarritoDeCompras
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            GestionCliente cliente = new GestionCliente();
            cliente.GuardarCliente("1112223334", "Michael Jackson", "Zambrano Zambrano", "michael@email.ec", "123");
            cliente.GuardarCliente("2223334445", "Juana Maria", "Pueblo Zambrano", "juan@mail.com", "123");
            Console.WriteLine(cliente.ListarUsuarios());

            GestionProductos producto = new GestionProductos();
            Console.WriteLine(producto.ListarProductos());
            // GRUPO 2
            // Utilizando expresiones lambda o linq cree los métodos en las capas respectivas que permitan mostrar por pantalla:
            //1) La existencia de un producto en particular dado su identificador. (1 Puntos)
            int existe = 5;
            string resultado = producto.existencia(existe);
            Console.WriteLine("El Producto con identificador numero {0}, existen {1} unidades ", existe,resultado);
            //2) Ordenar los productos por precio, de menor a mayor. (1 Puntos)
            Console.WriteLine("Productos ordenados por precio de menor a mayor");
            Console.WriteLine(producto.ProductosOrdenados());
            //3) Un listado de productos que sea mayor a un precio proporcionado por el usuario y ordendarlos por precio de mayor a menor. (2 Puntos)
            int valor = 9;
            Console.WriteLine("El valor ingresado fue {0} ",valor);
            Console.WriteLine(producto.ListaPrecioCliente(valor));
            //4) El producto con precio mas bajo. (2 Puntos)
            Console.WriteLine(producto.ProductoBajo());
            //5) El valor promedio de los precios de los productos. (2 Punto)
            Console.WriteLine("El Promedio total es: " +producto.PromedioProductos());
            Console.Clear();

        }


         
    }
}
