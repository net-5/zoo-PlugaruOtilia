using System;
using System.Collections.Generic;

namespace HomeworkZoo
{
    class Zoo
    {

        private string zooName;
        private Dictionary<string, string> animalsList = new Dictionary<string, string>();
        public static string animalName;
        private string favoriteFood;
        public static int contor;

        public Zoo(string name)
        {
            this.zooName = name;
        }

        public Dictionary<string, string> AnimalsList
        {
            get
            {
                return this.animalsList;
            }
        }

        public void Eat()
        { }

        static void AddAnimal()
        {
            animalName = "";
            contor = 0;
        }

        public void AddAnimal(string name, string food)
        {
            animalName = name;
            this.favoriteFood = food;
            contor++;
            this.animalsList.Add(name, food);
        }

        public static int GetContor()
        {
            return contor;
        }

        public void Transfer(string animal)
        {
            if (this.AnimalsList.ContainsKey(animal))
            {
                Console.Write(this.AnimalsList.Remove(animal));
                contor--;
            }
            else
            {
                Console.WriteLine("We don't have this animal in our garden.");
            }

        }

        public void PresentZoo()
        {
            int num = 1;
            Console.WriteLine("In gradina noastra " + this.zooName + " exista "  + "urmatoarele animale: ");
            foreach (var animal in this.AnimalsList)
            {
                Console.WriteLine(num + ". " + animal.Key + ", care prefera sa manance " + animal.Value);
                num++;
            }

        }

    }

    public class Program
    {
        public static void Main()
        {
            Zoo myZoo = new Zoo("Gradina zoo");
            myZoo.AddAnimal("veverita", "alune");
            myZoo.AddAnimal("lup", "oaie");
            myZoo.AddAnimal("vulpe", "pui");
            myZoo.AddAnimal("leu", "antilopa");
            myZoo.AddAnimal("elefant", "iarba");
            myZoo.AddAnimal("caprioara", "iarba");
            myZoo.AddAnimal("iepure", "morcov");
            myZoo.AddAnimal("vultur", "soareci");
            myZoo.AddAnimal("maimuta", "banane");
            myZoo.AddAnimal("sarpe", "soareci");
           
            myZoo.PresentZoo();
            myZoo.Transfer("elefant");
            myZoo.PresentZoo();

        }

    }
}