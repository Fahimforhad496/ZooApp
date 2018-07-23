using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooApp.Models.Migrations;
using AnimalFood = ZooApp.Models.AnimalFood;

namespace ZooApp.ViewModels
{
    public class ViewFoodTotal
    {
        public ViewFoodTotal(AnimalFood animalFood)
        {
            FoodName = animalFood.Food.Name;  // Grass
            FoodPrice = animalFood.Food.Price;  //10
            TotalQuantity = animalFood.Animal.Quantity * animalFood.Quantity; // 3*3=9
            TotalPrice = animalFood.Food.Price * TotalQuantity; 
        }

        public double TotalPrice { get;  } //OOP concept

        public double TotalQuantity { get; set; }

        public double FoodPrice { get; set; }

        public string FoodName { get; set; }
    }
}
