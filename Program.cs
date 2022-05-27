using Dio2.src.Entities;

class Program
{
    static void Main()
    {
        Guerreiro arus = new Guerreiro("Arus", 42, "Guerreiro", 469, 72);
        Ninja wedge = new Ninja("Wedge", 42, "Ninja", 292, 89);
        Mago jenica = new Mago("Jenica", 42, "Maga Branca", 325, 474);
        Mago topapa = new Mago("Topapa", 42, "Maga Negro", 106, 611);

        Console.WriteLine(arus.ToString());
        Console.WriteLine(arus.Ataque());
        Console.WriteLine("");

        Console.WriteLine(wedge.ToString());
        Console.WriteLine(wedge.Ataque());
        Console.WriteLine("");

        Console.WriteLine(jenica.ToString());
        Console.WriteLine(jenica.Ataque());
        Console.WriteLine("");

        Console.WriteLine(topapa.ToString());
        Console.WriteLine(topapa.Ataque());
        Console.WriteLine("");
    }
}