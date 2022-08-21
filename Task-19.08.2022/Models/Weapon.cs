using System;
using System.Collections.Generic;
using System.Text;

namespace Task_19._08._2022.Models
{
    class Weapon
    { 
        private int _stockCapacity;
        private int _currentAmount;
        private double _stockTime;
        private string _fireMode;

        public int StockCapacity
        { 
            get
            {
                return _stockCapacity;
            }
            set
            {
                if (value > 0) _stockCapacity = value;
            }
        }
        public int CurrentAmount 
        {
            get
            {
                return _currentAmount;
            }
            set
            {
                if (value >= 0 && value <= StockCapacity) _currentAmount = value;
            }
        } 
        public double StockTime 
        {
            get
            {
                return _stockTime;
            }
            set
            {
                if (value > 0) _stockTime = value;
            }
        }
        public string FireMode
        {
            get
            {
                return _fireMode;
            }
            set
            {
                if (value == "Single" || value == "Automatic") _fireMode = value;
            }
        }

        public Weapon(int stockCapacity, int currentAmount, double stockTime, string fireMode)
        {
            StockCapacity = stockCapacity;
            CurrentAmount = currentAmount;
            StockTime = stockTime;
            FireMode = fireMode;
        }
        public void GetInfo()
        {
            Console.WriteLine($"\nStock Capacity: {StockCapacity}\nCurrent Amount: {CurrentAmount}\nStock Time: {StockTime}\nFire Mode: {FireMode}");
        }
        public void Shoot()
        {
            Console.WriteLine("A bullet is shooted");
            CurrentAmount--;
        }
        public void Fire()
        {
            double TimeForOneBullet = StockTime / StockCapacity;

            if (FireMode == "Automatic")
            {
                Console.WriteLine("Spent Time: " + TimeForOneBullet * CurrentAmount);
                CurrentAmount = 0;
            }
            else if (FireMode == "Single") 
            {
                Console.WriteLine("Spent Time: " + TimeForOneBullet);
                CurrentAmount--;      
            }
            
        }
        public int GetRemainBulletCount()
        {
            return StockCapacity - CurrentAmount;
        }
        public void Reload()
        {
            CurrentAmount = StockCapacity;
        }
        public void ChangeFireMode()
        {
            if (FireMode == "Automatic") FireMode = "Single";
            else if (FireMode == "Single") FireMode = "Automatic";
        }
    }
}
