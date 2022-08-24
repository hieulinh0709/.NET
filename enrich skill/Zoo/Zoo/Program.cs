using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zoo.EventHandler;
using Zoo.EventHelper;
using Zoo.ZooManagement;

namespace Zoo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");

            ZooManager zooManager = new ZooManager();
            MenuManager menuManager = new MenuManager(zooManager);

            List<Cage> cages = zooManager.InitCages();

            zooManager.ShowInfoCages(cages);
            //cages[0].TimeForEat(1);

            //hiển thị màn hình chức năng cho Cage
            //menuManager.MenuCage();

            UserInput userInput = new UserInput();
            userInput.inputEvent += (sender, e) =>
            {
                InputData intput = (InputData)e;
                switch (intput.Data)
                {
                    case 1:
                        Cage cage = zooManager.HandleCreateCage();
                        cages.Add(cage);
                        zooManager.ShowInfoCages(cages);
                        break;
                    case 2:
                        menuManager.HandleSelectCage(cages);
                        break;
                    case 3:
                        //CreateCage();
                        break;
                    default:
                        break;
                }

            };
            userInput.Input();
        }

    }

}
