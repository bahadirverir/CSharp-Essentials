namespace PROJECT
{
  class Motorcycle : Vehicle
  {
    private int timingType; 
    public int TimingType 
    {
      get { return timingType; }
      set { timingType = value; }
    }
    private int cylinderNumber; 
    public int CyclinderNumber 
    {
      get { return cylinderNumber; }
      set { cylinderNumber = value; }
    }
    private string type; 
    public string Type 
    {
      get { return type; } 
      set { type = value; }
    }
   private static int ıd = 1; 
   public int ID { get; private set; } 

    public Motorcycle(string brand, string model, string type, int year, string fuel, 
                int kilometer, int engineSize, int horsePower, int timingType, 
                int cylinderNumber, string transmission, string color, int fuelConsumption)
    {
      ID = ıd++;
      Brand = brand;
      Model = model;
      Type = type;
      Year = year;
      Fuel = fuel;
      Kilometer = kilometer;
      EngineSize = engineSize;
      HorsePower = horsePower;
      TimingType = timingType;
      CyclinderNumber = cylinderNumber;
      Transmission = transmission;
      Color = color;
      FuelConsumption = fuelConsumption;
    }
  }
}