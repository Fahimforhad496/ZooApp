using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ZooApp.Models;
using ZooApp.ViewModels;

namespace ZooApp.Services
{
    public class AnimalService
    {
        //create  a db object
        ZooContext db = new ZooContext();

        public List<ViewAnimal> GetAnimals()
        {
           


            //Pulls all rows from table into RAM
            List<Animal> animals=db.Animals.ToList();


            //Convert this data  into view data

            List<ViewAnimal> viewAnimals = new List<ViewAnimal>();
            foreach (Animal animal in animals)
            {
                ViewAnimal viewAnimal = new ViewAnimal()
                {
                    Id = animal.Id,
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

        public ViewAnimal GetAnimal(int id)
        {
            Animal animal= db.Animals.Find(id);
            return new ViewAnimal()
            {
                Food = animal.Food,
                Quantity = animal.Quantity,
                Name = animal.Name,
                Type = animal.Type,
                Origin = animal.Origin,
                Price = animal.Price,
                Id = animal.Id

            
            };

        }


        public bool Save(Animal animal)                   
            {
                var add = db.Animals.Add(animal);
                db.SaveChanges();
                return true;

            }

        public bool Update(Animal animal)
        {
            db.Entry(animal).State = EntityState.Modified;
            db.SaveChanges();
            return true;
        }

        public bool Delete(Animal animal)
        {
            Animal dbAnimal = db.Animals.Find(animal.Id);
            db.Animals.Remove(dbAnimal);
            db.SaveChanges();
            return true;
        }

        public Animal GetDbAnimal(int id)
        {
            return db.Animals.Find(id);
        }
    }
}
