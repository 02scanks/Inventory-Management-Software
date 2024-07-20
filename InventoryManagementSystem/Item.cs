using System;

namespace InventoryManagementSystem
{
    public class Item
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public DateTime itemDate { get; set; }

    }
}
