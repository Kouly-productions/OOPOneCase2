using OOPOne;
using System;
using System.Linq.Expressions;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vichle vichle = new();
            while (true)
            {
                Enrollment x = new();
                Console.WriteLine("Vælg");
                Console.WriteLine("1) Opret kunde");
                Console.WriteLine("2) Søg på kunde");
                Console.WriteLine("3) Søg på mekaniker");
                int fortheswich = int.Parse(Console.ReadLine());
                switch (fortheswich)
                {
                    case 1:
                        Console.WriteLine("Write FirstName");
                        string firstname = Console.ReadLine();

                        Console.WriteLine("Write LastName");
                        string lastname = Console.ReadLine();

                        Console.WriteLine("write your phonenumber");
                        int phoneNumber = int.Parse(Console.ReadLine());

                        Customer customer = new(firstname, lastname, phoneNumber);

                        Console.WriteLine("write numberplate");
                        string numberPlate = Console.ReadLine();

                        Console.WriteLine("write brand");
                        string brand = Console.ReadLine();

                        Console.WriteLine("write model");
                        string model = Console.ReadLine();

                        Console.WriteLine("write year of regerstration");
                        DateTime year = Convert.ToDateTime(Console.ReadLine());

                        Console.WriteLine("Write VichleType");
                        Console.WriteLine("Write 'Bil' 'Motorcykel' or 'Lastbil'");
                        string vichleType = Console.ReadLine();

                        Console.Clear();

                        if (vichleType == vehicleEnum.Bil.ToString())
                        {
                            Mechanic Martin = new Mechanic("Martin", "Jensen", 11111111, vehicleEnum.Bil);
                            vichle.vichleList.Add(new Vichle(numberPlate, brand, model, year, customer, Martin));
                        }
                        else if (vichleType == vehicleEnum.Motorcykel.ToString())
                        {
                            Mechanic Thomas = new Mechanic("Thomas", "Hansen", 22222222, vehicleEnum.Motorcykel);
                            vichle.vichleList.Add(new Vichle(numberPlate, brand, model, year, customer, Thomas));
                        }
                        else if (vichleType == vehicleEnum.Lastbil.ToString())
                        {
                            Mechanic Henrik = new Mechanic("Henrik", "Nielsen", 33333333, vehicleEnum.Lastbil);
                            vichle.vichleList.Add(new Vichle(numberPlate, brand, model, year, customer, Henrik));
                        }
                        Vichle vichles = new Vichle();
                        break;
                    case 2:
                        Console.WriteLine("Write name of customer");
                        string customSearch = Console.ReadLine();
                        foreach (var item in vichle.vichleList)
                        {
                            if(customSearch == item.Owner.FirstName)
                            {
                                Console.Clear();
                                Console.WriteLine($"Der blev fundet følgende");
                                item.Owner.GetAllVichles(x);
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("None was found");
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("Write name of a mechanic");
                        string customSearchMechanic = Console.ReadLine();
                        foreach (var item in vichle.vichleList)
                        {
                            if (customSearchMechanic == item.Owner.FirstName)
                            {
                                Console.Clear();
                                Console.WriteLine($"Der blev fundet følgende");
                                item.Owner.GetAllVichles(x);
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("None was found");
                            }
                        }
                        break;
                }

                foreach (var item in vichle.vichleList)
                {
                    Console.WriteLine($"{item.Owner.FirstName} {item.Owner.LastName} {item.NumberPlate} {item.Mechanic.FirstName}");
                }
            }
        }
    }
}