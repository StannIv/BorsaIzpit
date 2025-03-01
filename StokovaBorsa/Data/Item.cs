﻿namespace StokovaBorsa.Data
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TypeProductId { get; set; }
        public TypeProduct TypeProducts { get; set; }
        public string Description { get; set; }
        public string Photo {  get; set; }
        public decimal Price { get; set; }
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
