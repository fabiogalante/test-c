﻿namespace BelezaNaWeb.Core.Model
{
    public class Product
    {
      

        public int Sku { get; set; }

       
        public string Name { get; set; }

       
        public Inventory Inventory { get; set; }


        public bool IsMarketable => Inventory.Quantity > 0;
    }
}
