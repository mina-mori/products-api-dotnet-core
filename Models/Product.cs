using System;

namespace ProductsAPI
{
    public class Product
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public String ImgURL { get; set; }
        public int CategoryID { get; set; }
    }
}
