using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Parking
    {
        
       
        public int size { get; set; }
        public List<bool> spots { get; set; }


       
        public Parking(int size)
        {
            this.size = size;
            spots = Enumerable.Repeat(false, size).ToList();

        }
        //public void Execute()
        //{
        //    foreach (var item in spots)
        //    {
        //        Console.WriteLine(item);
                
        //    }
        //}
        public bool ParkCar(int position)
        {
            if (position < 0 || position >= size)
            {
                Console.WriteLine("Невірна позиція для паркування.");
                return false;
            }

            for (int i = position; i < size; i++)
            {
                if (!spots[i])
                {
                    spots[i] = true;
                    Console.WriteLine($"Машина припаркована на місці {i}.");
                    return true;
                }
            }

            Console.WriteLine("Немає вільних місць для паркування.");
            return false;
        }

        public bool LeaveCar(int position)
        {
            if (position < 0 || position >= size || !spots[position])
            {
                Console.WriteLine("Машини на цьому місці немає.");
                return false;
            }

            spots[position] = false;
            Console.WriteLine($"Машина виїхала з місця {position}.");
            return true;
        }

        public void DisplayParkingLot()
        {
            Console.WriteLine("Стан автостоянки:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(spots[i] ? "[X] " : "[ ] ");
            }
            Console.WriteLine();



        }
    }
}
