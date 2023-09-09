Violin violin = new Violin("Violin", "Violin is a string musical instrument.", "The violin was developed in the 16th century.");
Trombone trombone = new Trombone("Trombone", "Trombone is a brass wind musical instrument.", "The trombone was created in the 15th century.");
Ukulele ukulele = new Ukulele("Ukulele", "Ukulele is a string musical instrument associated with Hawaii.", "Ukulele emerged in the late 19th century.");
Cello cello = new Cello("Cello", "Cello is a string musical instrument.", "The cello has existed since the 16th century.");

violin.Sound();
violin.Show();
violin.Desc();
violin.History();

trombone.Sound();
trombone.Show();
trombone.Desc();
trombone.History();

ukulele.Sound();
ukulele.Show();
ukulele.Desc();
ukulele.History();

cello.Sound();
cello.Show();
cello.Desc();
cello.History();

class MusicalInstrument
{
    private string name;
    private string description;
    private string history;

    public MusicalInstrument(string name, string description, string history)
    {
        this.name = name;
        this.description = description;
        this.history = history;
    }

    public void Sound()
    {
        Console.WriteLine($"musical instrument produces the sound of the {name}");
    }

    public void Show()
    {
        Console.WriteLine($"Name: {name}");
    }

    public void Desc()
    {
        Console.WriteLine($"Description: {description}");
    }

    public void History()
    {
        Console.WriteLine($"Creation History: {history}");
    }
}

class Violin : MusicalInstrument
{
    public Violin(string name, string description, string history) : base(name, description, history)
    {
    }
}

class Trombone : MusicalInstrument
{
    public Trombone(string name, string description, string history) : base(name, description, history)
    {
    }
}

class Ukulele : MusicalInstrument
{
    public Ukulele(string name, string description, string history) : base(name, description, history)
    {
    }
}

class Cello : MusicalInstrument
{
    public Cello(string name, string description, string history) : base(name, description, history)
    {
    }
}

