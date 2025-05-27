namespace Commandos.Models
{
    public class AirCommando : Commando
    {
        public AirCommando(string name, string codeName, List<string>tools, string type) : base(name, codeName, tools,type)
        {
        }
        public void Parachuting()
        {
            Status = "Parachuting";
            System.Console.WriteLine("Soldier parachuting");
        }
    }
}