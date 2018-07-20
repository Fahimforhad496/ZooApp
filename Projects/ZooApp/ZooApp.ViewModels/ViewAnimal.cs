using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooApp.Models;

namespace ZooApp.ViewModels
{
    public class ViewAnimal
    {
        public ViewAnimal(Animal animal )
        {
            Id = animal.Id;
            Origin = animal.Origin;
            Type = animal.Type;
            Quantity = animal.Quantity;
            Name = animal.Name;
            Price = animal.Price;
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public string Origin { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        [StringLength(100)]

        public string Type { get; set; }
    }
}
