namespace Commandos.Models
{
    public class CommandoFactory
    {
        public static List<Commando> CommandoObjList = new List<Commando>();
        public static string[] NamsList = { "israel", "Moshe", "Or", "Dan", "Yosef" };
        public static string[] tools = { "Hammer", "chisel", "rope", "bag", "water bottle" };

        public static void InitCommando(string type, int ammount)
        {
            for (int i = 0; i < ammount; i++)
            {
                CommandoObjList.Add(Creation(type));
            }
        }

        private static Commando Creation(string type)
        {
            Commando commando;
            string codeName = ChoiceName()[0].ToString();
            switch (type)
            {
                case "Air":
                    return commando = new AirCommando(ChoiceName(), codeName, CreationToolsList(), "AirCommando");
                case "Sea":
                    return commando = new SeaCommando(ChoiceName(), codeName, CreationToolsList(), "SeaCommando");
                default:    
                    return commando = new Commando(ChoiceName(), codeName, CreationToolsList(), "Commando");
                
            }
            return null;
        }
        static private string ChoiceName()
        {
            Random random = new Random();
            string myName = NamsList[random.Next(NamsList.Length)];
            return myName;
        }

        private static List<string> CreationToolsList()
        {
            Random random = new Random();
            List<string> myTools = new List<string>();
            for (int i = 0; i < random.Next(tools.Length); i++)
            {
                myTools.Add(tools[i]);
            }
            return myTools;

        }   
    }
}