using System.Collections;
using System;


namespace Ticket
{
    class Recibo
    {
        ArrayList items;
        public Recibo()
        {
            this.items = new ArrayList();
        }
        
        public void AddProducto(Producto producto)
        {
            this.items.Add(producto);
        }

        public int totalPrice; //ojo aca. Esta variable la tenes que volver a cero
        //cada vez que le pedis el total al recibo

        
        public int GetTotal()
        {
            totalPrice = 0;
            //bien. Ahora tenes otro tema aca. 
            //Vos definiste esta variable como de instancia. Es parte del objeto
            //pero en realidad NO es parte del objeto. Es algo que le pido al objeto 
            // que calcule en un momento dado. No necesito almacenar el total
            foreach (Producto items in this.items)
            {
                totalPrice = totalPrice + items.price;
            }
            return totalPrice;
        }

        
        public ArrayList ProductList()
        {
            ArrayList list = new ArrayList();
            foreach (Producto producto in this.items)
            {
                list.Add(producto);
                
            }
            
            return list;
        }    

    }

}