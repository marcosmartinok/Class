using System.Collections;
using System;
using System.Text;


namespace Ticket
{
    class Impresora
    {
        public void PrintTicket(Recibo recibo, int choice)
        {  
            
            StringBuilder formato = new StringBuilder();
            if (choice == 1)
            {
                formato.Append(" ---- ");
            }
            else if (choice == 2)
            {
                formato.Append(" .... $ ");
            }
            
                    
            foreach (Producto item in recibo.ProductList())
            {
                Console.WriteLine("{0} {1} {2}", item.name, formato, item.price);
            }
            
            Console.WriteLine(recibo.GetTotal());       
        }

        

              
    }
}