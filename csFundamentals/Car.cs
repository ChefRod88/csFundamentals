namespace csFundamentals;

class Car
{
    String make;
    String model;
    int year;
    String color;

    public Car(String make, String model, int year, String color)
    {
        this.make = make;
        this.model = model;
        this.year = year;
        this.color = color;
    }

    public void Drive()
    {
        Console.WriteLine("You drive the " + color + " " + make + " " + model);
    }
      
}