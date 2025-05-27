namespace Commandos.Models
{
    public class SeaCommando : Commando
    {
        public SeaCommando(string name, string codeName, List<string> tools, string type) : base(name, codeName, tools, type)
        {
        }
        public void Swimming()
        {
            Status = "Swimming";
            System.Console.WriteLine("Soldier Swimming");
        }
    }
}