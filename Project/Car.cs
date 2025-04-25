namespace PROJECT
{
  class Car : Vehicle
  {
   private string series; 
   public string Series 
   {
      get { return series; } 
      set { series = value; }
   }
   private string drive; 
   public string Drive 
   {
      get { return drive; } 
      set { drive = value; }
   }
   private string bodyType; 
   public string BodyType 
   {
      get { return bodyType; } 
      set { bodyType = value; }
   }
   private static int ıd = 1; 
   public int ID { get; private set; } 
       
   public Car(string brand, string series, string model, int year, string fuel, 
               string transmission, int kilometer, string bodyType, int horsePower, 
               int engineSize, string drive, string color, int fuelConsumption)
   {    
    ID = ıd++;
    Brand = brand;
    Series = series;
    Model = model;
    Year = year;
    Fuel = fuel;
    Transmission = transmission;
    Kilometer = kilometer;
    BodyType = bodyType;
    HorsePower = horsePower;
    EngineSize = engineSize;
    Drive = drive;
    Color = color;
    FuelConsumption = fuelConsumption;
   }  
  }
}