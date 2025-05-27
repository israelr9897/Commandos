namespace Commandos.Models
{
    public class Commando
    {
        private string Name;
        public string CodeName;
        public List<string> Tools = new List<string>();
        public string Status = "";
        public string Type;

        public Commando(string name, string codeName, List<string> tools, string type)
        {
            Name = name;
            CodeName = codeName;
            Tools = tools;
            Type = type;
        }
        public void SayName(string commanderRank)
        {
            switch (commanderRank)
            {
                case "GENERAL":
                    System.Console.WriteLine(Name);
                    break;

                case "COLONEL":
                    System.Console.WriteLine(CodeName);
                    break;

                default:
                    System.Console.WriteLine("The information cannot be provided because it is classified information for your rank.");
                    break;
            }
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