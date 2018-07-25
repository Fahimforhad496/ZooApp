using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooApp.Models;

namespace ZooApp.ViewModels
{
    public class ViewFoodAnimalTotal
    {
        public ViewFoodAnimalTotal(AnimalFood animalFood)
        {
           

        }

        public ViewFoodAnimalTotal()
        {
        }

        public int Id { get; set; }

        public double TotalPrice { get; set; } //OOP concept

        public double TotalQuantity { get; set; }

        public string AnimalName { get; set; }
    }
}
