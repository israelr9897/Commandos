namespace Commandos.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tools = { "Hammer", "chisel", "rope", "bag", "water bottle" };
            Commando c1 = new Commando("iaerl", "isr", tools, "Hide");
            c1.Walk();
            System.Console.WriteLine(c1.Status);
        }
    }
}