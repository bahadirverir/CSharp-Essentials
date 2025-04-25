namespace PROJECT
{
  class Program
  {
    static void Main(string[] args)
    {
      while (true)
      {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("1-) Add Car");
        Console.WriteLine("2-) Delete Car");
        Console.WriteLine("3-) Add Motorcycle");
        Console.WriteLine("4-) Delete Motorcycle");
        Console.WriteLine("5-) List Cars");
        Console.WriteLine("6-) List Motorcycles");
        Console.WriteLine("7-) Exit Program\n");
        Console.Write("Option >>> ");
        int option ;
        
        try 
        {
          option = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException)
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.Write("\nInvalid input try again.\n");
          continue ;
        }

        switch (option)
        {
          case 1:
          string carBrand = Methods.StringInput("Brand: ");
          string carSerie = Methods.StringInput("Serie: ");
          string carModel = Methods.StringInput("Model: ");
          int carYear = Methods.IntInput("Year: ");
          string carFuel = Methods.StringInput("Fuel: ");
          string carTransmission = Methods.StringInput("Transmission: ");
          int carKilometer = Methods.IntInput("Kilometer: ");
          string carBodyType = Methods.StringInput("Body type: ");
          int carHorsePower = Methods.IntInput("Horse power: ");
          int carEngineSize = Methods.IntInput("Engine size: ");
          string carDrive = Methods.StringInput("Drive: ");
          string carColor = Methods.StringInput("Color: ");
          int carFuelConsumption = Methods.IntInput("Fuel consumption: ");
          
          Car car = new Car(carBrand,carSerie,carModel,carYear,carFuel,
                            carTransmission,carKilometer,carBodyType,carHorsePower,
                            carEngineSize,carDrive,carColor,carFuelConsumption);

          Methods.AddCar(car);
          Console.WriteLine("Returning to main menu...");
          Thread.Sleep(2500);
          Console.Clear();
          break;

          case 2: 
          Methods.DeleteCar();
          break;

          case 3: 
          string motorcycleBrand = Methods.StringInput("Brand: ");
          string motorcycleModel = Methods.StringInput("Model: ");
          string motorcycleType = Methods.StringInput("Type: ");
          int motorcycleYear = Methods.IntInput("Year: ");
          string motorcycleFuel = Methods.StringInput("Fuel: ");
          int motorcycleKilometer = Methods.IntInput("Kilometer: ");
          int motorcycleEngineSize = Methods.IntInput("Engine size: ");
          int motorcycleHorsePower = Methods.IntInput("Horse power: ");
          int motorcycleTimingType = Methods.IntInput("Timing type: ");
          int motorcycleCyclinderNumber = Methods.IntInput("Cyclinder number: ");
          string motorcycleTransmission = Methods.StringInput("Transmission: ");
          string motorcycleColor = Methods.StringInput("Color: ");
          int motorcycleFuelConsumption = Methods.IntInput("Fuel consumption: ");
          
          Motorcycle motorcycle = new Motorcycle(motorcycleBrand,motorcycleModel,motorcycleType,motorcycleYear,motorcycleFuel,
                                  motorcycleKilometer,motorcycleEngineSize,motorcycleHorsePower,motorcycleTimingType,
                                  motorcycleCyclinderNumber,motorcycleTransmission,motorcycleColor,motorcycleFuelConsumption);
          
          Methods.AddMotorcycle(motorcycle);
          Console.WriteLine("Returning to main menu...");
          Thread.Sleep(2500);
          Console.Clear();
          break;

          case 4: 
            Methods.DeleteMotorcycle();  
            break;

          case 5: 
            Methods.ListCars();
            break;

          case 6: 
            Methods.ListMotorcycles();
            break;

          case 7:
            Console.WriteLine("Program succesfully closed.");
            return;

          default: 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nInvalid input try again.");
            while (true) 
            {
              Console.WriteLine("1-) Return to main menu.");
              Console.WriteLine("2-) Exit program.");
              Console.Write("\nOption >>  ");
              
              try
              {
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                  Console.WriteLine("Returning to main menu...");
                  Thread.Sleep(2000);
                  Console.Clear();
                  break;
                }
                else if (choice == 2)
                {
                  Console.WriteLine("Program succesfully closed.");
                  return;
                }
                else
                {
                  Console.WriteLine("Invalid input try again.");
                }
                }
                catch (FormatException) 
                {
                  Console.WriteLine("Invalid input try again.");
                }
              }
          break;
        }
      }
    }
  }
}