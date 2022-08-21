using System;
using Task_19._08._2022.Models;

namespace Task_19._08._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Stock Capacity: ");
            int StockCapacity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Current Amount of bullets in the stock: ");
            int CurrentAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Time that discharges the stock: ");
            double StockTime = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Fire Mode: Automatic or Single");
            string FireMode = Console.ReadLine();
            
            string value;
            Weapon weapon = new Weapon(StockCapacity, CurrentAmount, StockTime, FireMode);
            do
            {
                Console.WriteLine("\n0. Getting Information\n1. Shoot\n2. Fire\n3. GetRemainBulletCount\n4. Reload\n5. ChangeFireMode\n6. Exit\n7. Edit the input");
                value = Console.ReadLine();
                switch (value)
                {
                    case "0":
                        weapon.GetInfo();
                        break;
                    case "1":
                        weapon.Shoot();
                        break;
                    case "2":
                        weapon.Fire();
                        break;
                    case "3":
                        Console.WriteLine("Remain Bullets: " + weapon.GetRemainBulletCount());
                        break;
                    case "4":
                        weapon.Reload();
                        Console.WriteLine("The Stock was reloaded");
                        break;
                    case "5":
                        weapon.ChangeFireMode();
                        Console.WriteLine("The Fire mode was changed");
                        break;
                    case "6":
                        break;
                    case "7":
                        Console.WriteLine("Press T for changing the Stock Capacity\nPress S for changing CurrentAmount\nPress D for changing the StockTime");
                        string value1 = (Console.ReadLine());
                        if (value1 == "T") { Console.Write("Enter the new value: "); weapon.StockCapacity = Convert.ToInt32(Console.ReadLine()); }
                        else if (value1 == "S") { Console.Write("Enter the new value: "); weapon.CurrentAmount = Convert.ToInt32(Console.ReadLine()); }
                        else if (value1 == "D") { Console.Write("Enter the new value: "); weapon.StockTime = Convert.ToDouble(Console.ReadLine()); }
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }

            } while (value != "6");
            
            
            
        }
    }
}
