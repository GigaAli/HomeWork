Teapot teapot = new Teapot("My Teapot");
Microwave microwave = new Microwave("Kitchen Microwave");
Car car = new Car("Family Car");
Steamboat steamboat = new Steamboat("Steamboat");


Console.WriteLine();

teapot.Show();
teapot.Sound();
teapot.Desc();

Console.WriteLine();

microwave.Show();
microwave.Sound();
microwave.Desc();

Console.WriteLine();

car.Show();
car.Sound();
car.Desc();

Console.WriteLine();

steamboat.Show();
steamboat.Sound();
steamboat.Desc();

class Device
{
    public string Name { get; set; }

    public Device(string name)
    {
        Name = name;
    }

    public virtual void Sound()
    {
        Console.WriteLine($"Device {Name} makes a generic sound.");
    }

    public void Show()
    {
        Console.WriteLine($"Device: {Name}");
    }

    public virtual void Desc()
    {
        Console.WriteLine($"This is a {Name}.");
    }
}

class Teapot : Device
{
    public Teapot(string name) : base(name)
    {
    }

    public override void Sound()
    {
        Console.WriteLine($"Teapot {Name} whistles when it's ready.");
    }

    public override void Desc()
    {
        Console.WriteLine($"This is a teapot named {Name}. It's used for boiling water.");
    }
}

class Microwave : Device
{
    public Microwave(string name) : base(name)
    {
    }

    public override void Sound()
    {
        Console.WriteLine($"Microwave {Name} beeps when it's done heating.");
    }

    public override void Desc()
    {
        Console.WriteLine($"This is a microwave named {Name}. It's used for heating food.");
    }
}

class Car : Device
{
    public Car(string name) : base(name)
    {
    }

    public override void Sound()
    {
        Console.WriteLine($"Car {Name} engine sounds vroom-vroom.");
    }

    public override void Desc()
    {
        Console.WriteLine($"This is a car named {Name}. It's a mode of transportation.");
    }
}

class Steamboat : Device
{
    public Steamboat(string name) : base(name)
    {
    }

    public override void Sound()
    {
        Console.WriteLine($"Steamboat {Name} produces a chugging sound.");
    }

    public override void Desc()
    {
        Console.WriteLine($"This is a steamboat named {Name}. It's a type of watercraft.");
    }
}

