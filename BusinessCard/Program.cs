namespace BusinessCard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\tTim Smets");
            Console.ResetColor();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"{"Opleiding:", -15}   Graduaat programmeren");
            Console.WriteLine($"{"Klasgroep:", -15}   1PROc");
            Console.WriteLine($"{"Favoriete vak:", -15}   Werkplekleren");

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("schoon kaartje");
            Console.ResetColor();
        }
    }
}
