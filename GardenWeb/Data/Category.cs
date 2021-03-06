﻿using System.Collections.Generic;

namespace GardenWeb.Data
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<SubCategory> SubCategories { get; set; }
    }
}