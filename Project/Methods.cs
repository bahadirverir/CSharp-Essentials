namespace PROJECT
{
  class Methods
  {
   public static List<Car> Cars = new List<Car>();
   public static List<Motorcycle> Motorcycles = new List<Motorcycle>();
   
   public static void AddCar(Car car)
   {
    Cars.Add(car);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\nCar succesfully added.");
   }

   public static void AddMotorcycle(Motorcycle motorcycle)
   {
    Motorcycles.Add(motorcycle);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\nMotorcycle succesfully added.");
   }
   
    public static void DeleteCar()
    {
    Console.Write("Enter the ID of the car you want to delete: ");
    int id = Convert.ToInt32(Console.ReadLine());
    Car car = Cars.Find(a => a.ID == id);
    if (car != null)
    {
        Cars.Remove(car);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Car succesfully deleted.\n");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nNo car exists with the entered ID.\n");
    }
    }

    public static void DeleteMotorcycle()
    {
    Console.Write("Enter the ID of the motorcycle you want to delete: ");
    int id = Convert.ToInt32(Console.ReadLine());
    Motorcycle motorcycle = Motorcycles.Find(m => m.ID == id);
    if (motorcycle != null)
    {
        Motorcycles.Remove(motorcycle);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Motorcycle succesfully deleted.\n");
    }
    else
    {   
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nNo motorcycle exists with the entered ID.\n");
    }
    }
    
    public static void ListCars()
    {
    if (Cars.Count == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nNo cars available to list.\n");
        return;
    }
    Console.WriteLine("\nCars are being listed...\n");
    foreach (var car in Cars)
    {
        Console.WriteLine("ID: {0}\nBrand: {1}\nSeries: {2}\nModel: {3}\nYear: {4}",car.ID,car.Brand,car.Series,car.Model,car.Year);
        Console.WriteLine("Fuel: {0}\nTransmission: {1}\nKilometer: {2}",car.Fuel,car.Transmission,car.Kilometer);
        Console.WriteLine("Body type: {0}\nHorse power: {1}\nEngine size: {2}",car.BodyType,car.HorsePower,car.EngineSize);
        Console.WriteLine("Drive: {0}\nColor: {1}\nFuel consumption: {2}\n",car.Drive,car.Color,car.FuelConsumption);
    }
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Existing cars have been successfully listed.\n");
    }
    
    public static void ListMotorcycles()
    {
    if (Motorcycles.Count == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nNo motorcycles available to list.\n");
        return;
    }
    Console.WriteLine("\nMotorcycles are being listed...\n");
    foreach (var motorcycle in Motorcycles)
    {
        Console.WriteLine("ID: {0}\nBrand: {1}\nModel: {2}\nType: {3}\nYear: {4}",motorcycle.ID,motorcycle.Brand,motorcycle.Model,motorcycle.Type,motorcycle.Year);
        Console.WriteLine("Fuel: {0}\nKilometer: {1}\nEngine size: {2}",motorcycle.Fuel,motorcycle.Kilometer,motorcycle.EngineSize);
        Console.WriteLine("Horse power: {0}\nTiming type: {1}\nCyclinder number: {2}",motorcycle.HorsePower,motorcycle.TimingType,motorcycle.CyclinderNumber);
        Console.WriteLine("Transmission: {0}\nColor: {1}\nFuel consumption: {2}\n",motorcycle.Transmission,motorcycle.Color,motorcycle.FuelConsumption);  
    }
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Existing motorcycles have been successfully listed.\n");
   }
   
   public static string StringInput(string prompt)
   {
    string input;
    while (true)
    {
        Console.Write(prompt);
        input = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(input))
        {
        break;
        }
        Console.WriteLine("Invalid input; empty values are not allowed try again.");
    }
    return input;
    }
   
    public static int IntInput(string prompt)
    {
    int result;
    while (true)
    {
        Console.Write(prompt);
        if (int.TryParse(Console.ReadLine(), out result))
        {
        break;
        }
        Console.WriteLine("Invalid input enter a valid integer.");
    }
    return result;
    }
  } 
}