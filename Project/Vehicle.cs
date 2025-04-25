namespace PROJECT
{
  abstract class Vehicle
  {
    private string brand; 
    public string Brand 
    { 
        get { return brand; }
        set { brand = value; }
    }
    private string color; 
    public string Color 
    {
        get { return color; } 
        set { color = value; }
    }
    private string fuel; 
    public string Fuel 
    {
        get { return fuel; } 
        set { fuel = value; }
    }
    private string transmission; 
    public string Transmission
    {
        get { return transmission; } 
        set { transmission = value; }
    }
    private string model; 
    public string Model 
    {
        get { return model; } 
        set { model = value; }
    }
    private int year;
    public int Year 
    {
        get { return year; }
        set { year = value; }
    }
    private int kilometer;
    public int Kilometer 
    {
        get { return kilometer; }
        set { kilometer = value; }
    }
    private int horsePower;
    public int HorsePower 
    {
        get { return horsePower; }
        set { horsePower = value; }
    }
    private int engineSize; 
    public int EngineSize 
    {
        get { return engineSize; }
        set { engineSize = value; }
    }
    private int fuelConsumption; 
    public int FuelConsumption 
    {
        get { return fuelConsumption; }
        set { fuelConsumption = value; }
    }
  }
}