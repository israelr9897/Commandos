namespace Commandos.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tools = { "Hammer", "chisel", "rope", "bag", "water bottle" };
            Commando c1 = new Commando("israel", "isr", tools, "Hide");
            System.Console.WriteLine(c1.CodeName);
            c1.CodeName = "rrrr";
            System.Console.WriteLine(c1.CodeName);
            // c1.Walk();
            // c1.SayName("GENERAL");
        }
    }
}