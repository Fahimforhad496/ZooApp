using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooApp.Models;
using ZooApp.ViewModels;

namespace ZooApp.Services
{
    public class AnimalService
    {

        public List<ViewAnimal> GetAnimals()
        {
           //create  a db object
           ZooContext db = new ZooContext();


            //Pulls all rows from table into RAM
            List<Animal> animals=db.Animals.ToList();


            //Convert this data  into view data

            List<ViewAnimal> viewAnimals = new List<ViewAnimal>();
            foreach (Animal animal in animals)
            {
                ViewAnimal viewAnimal = new ViewAnimal()
                {
                    Id =animal.Id,
                    Quantity = animal.Quantity,
                    Origin = animal.Origin,
                    Type= animal.Type,
                    Food = animal.Food,
                    Name= animal.Name,
                    Price = animal.Price,
                };
                viewAnimals.Add(viewAnimal);
            }
            return viewAnimals;
        }
    }
}
