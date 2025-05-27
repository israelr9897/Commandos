namespace Commandos.Models
{
    public class Commando
    {
        public string Name;
        public string CodeName;
        public string[] Tools;
        public string Status;

        public Commando(string name, string codeName, string[]tools, string status)
        {
            Name = name;
            CodeName = codeName;
            Tools = tools;
            Status = status;
       

        }

        public void Walk()
        {
            Status = "Walk";
            System.Console.WriteLine("A soldier walks");
        }
        public void Hide()
        {
            Status = "Hide";
            System.Console.WriteLine("A soldier is hiding.");
        }
        public void Attack()
        {
            Status = "Attack";
            System.Console.WriteLine($"Commando with codename {CodeName} is active.");
        }

    }
}