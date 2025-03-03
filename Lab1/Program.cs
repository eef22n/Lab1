using Lab1;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
       

        //task1
        Parking parking = new Parking(10);
        parking.ParkCar(1);
        parking.ParkCar(0);
        parking.ParkCar(1);
        parking.ParkCar(9);
        parking.LeaveCar(1);
        parking.ParkCar(1);
        parking.LeaveCar(3);
        parking.DisplayParkingLot();
        Console.WriteLine();

        //task2
        Dict dict = new Dict();
        dict.dict.Add("af", "sdf");
        dict.dict.Add("123", "123");
        dict.dict.Add("qwerty", "qwerty");
        dict.dict.Add("345", "543");
        dict.PrintDict();
        dict.IsEqual();
        Console.WriteLine();

        //task3
        List<int> numbers = new List<int> { 2, 5, 7, 10, 15, 18, 20 };
        Linq linq = new Linq(numbers);
        linq.CalculateAverage();




    }

}