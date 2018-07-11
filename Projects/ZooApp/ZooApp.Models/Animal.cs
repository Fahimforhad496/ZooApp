using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp.Models
{
    public class Animal
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Food { get; set; }

        public string Origin { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        [StringLength(100)]

        public string Type { get; set; }
    }
}
