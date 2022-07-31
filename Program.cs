namespace madlibgame_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your favourite color : ");
            string color = Console.ReadLine();
            Console.Write("Enter your favourite object : ");
            string thing =  Console.ReadLine();
            Console.Write("Enter your lovers name: ");
            string lover = Console.ReadLine();
            lover = char.ToUpper(lover[0]) + lover.Substring(1);//converting first letter to capital as !totitle function 
            Console.Write("\nThe poem be : \n");
            Console.WriteLine("Roses are " + color);
            Console.WriteLine(thing + " are blue");
            Console.WriteLine("I Love " + lover);
        }
    }
}