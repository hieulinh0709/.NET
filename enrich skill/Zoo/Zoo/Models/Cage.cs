using System;
using System.Collections.Generic;
using Zoo.EventHelper;
using Zoo.ZooManagement;

namespace Zoo
{
    public class Cage
    {
        public event EventHandler<HaveFoodEvent> HaveFoodEvent;
        public Guid Code { get; set; }
        public string Name { get; set; }
        public List<BaseAnimal> animals { get; set; }
        public Cage()
        {

        }
        public Cage(Guid code, string name)
        {
            Code = code;
            Name = name;
        }

        public void TimeForEat(Food food)
        {
            HaveFoodEvent?.Invoke(this, new HaveFoodEvent(food));
        }

        public void Select()
        {
            Console.WriteLine("Select Cage");
        }

        public void Create()
        {
            Console.WriteLine("Nhập thông tin để tạo Lồng");
            bool isValid = true;

            Code = Guid.NewGuid();

            do
            {
                Console.WriteLine("Name: ");
                Name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(Name))
                    isValid = false;

            } while (!isValid);

        }
        public void DeleteAnimal(BaseAnimal animal)
        {
            animals.Remove(animal);
        }

        public void AddAnimal(BaseAnimal animal)
        {
            animals.Add(animal);
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{Code} | {Name}");
        }

        public void ShowInfoAnimals(List<BaseAnimal> animals)
        {
            Console.WriteLine("\n=========DANH SÁCH ĐỘNG VẬT==========");
            Console.WriteLine("\nMã động vật\t\t\t\t\t Tên động vật");
            foreach (var animal in animals)
            {
                animal.ShowInFo();
            }
        }

    }
}
