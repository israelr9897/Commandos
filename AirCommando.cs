namespace Commandos.Models
{
    public class AirCommando : Commando
    {
        public AirCommando(string name, string codeName, string[] tools, string status) : base(name, codeName, tools, status)
        {
        }
        public void Parachuting()
        {
            Status = "Parachuting";
            System.Console.WriteLine("Soldier parachuting");
        }
    }
}