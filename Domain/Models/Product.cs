using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public string Category { get; set; }
        public string[] Images { get; set; }
        public bool IsAvailable { get; set; }


        public Product()
        {

        }
        public Product(Guid id, string title, string description, decimal cost, 
            string category, string[] images, bool avaliability)
        {
            Id = id;
            Title = title;
            Description = description;
            Cost = cost;
            Category = category;
            Images = images;
            IsAvailable = avaliability;
        }
    }
}
