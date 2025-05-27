namespace Commandos.Models
{
    public class SeaCommando : Commando
    {
        public SeaCommando(string name, string codeName, string[] tools, string status) : base(name, codeName, tools, status)
        {
        }
        public void Swimming()
        {
            Status = "Swimming";
            System.Console.WriteLine("Soldier Swimming");
        }
    }
}