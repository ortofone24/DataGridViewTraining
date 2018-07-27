using System;

namespace ProductList
{
    public class Product
    {
        public Guid Id { get; private set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public string Country { get; set; }

        public double Sale { get; set; }

        public Product(Guid p_id, string p_name, double p_price, string p_country, double p_sale)
        {
            Id = p_id;
            Name = p_name;
            Price = p_price;
            Country = p_country;
            Sale = p_sale;
        }
    }
}