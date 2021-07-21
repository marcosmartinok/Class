using System;

namespace Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            
            Producto manzana = new Producto("Apple", 20);
            Producto naranja = new Producto("Orange", 30);
            Producto frutilla = new Producto("Strawberry", 50);
            Producto durazno = new Producto("Peach", 25);

            Recibo rechnung = new Recibo();

            rechnung.AddProducto(manzana);
            rechnung.AddProducto(naranja);
            rechnung.AddProducto(frutilla);
            rechnung.AddProducto(durazno);

            Impresora print = new Impresora();
            while (option != 3 )
            {

                System.Console.Write("Choose Option (3 to exit): ");
                string choice = Console.ReadLine();
                option = Int32.Parse(choice);
                if (option == 1 || option == 2)
                {
                    print.PrintTicket(rechnung, option);
                    break;
                }
            }
            Console.WriteLine("End!");
            
            

        }
    }
}
