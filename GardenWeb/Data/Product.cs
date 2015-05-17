using System;

namespace GardenWeb.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public DateTime? Created { get; set; }

        public Category Category { get; set; }

    }
}