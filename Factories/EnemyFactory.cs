namespace Commandos.Models
{
    public class EnemyFactory
    {
        public static List<Enemy> EnemyList = new List<Enemy>();
        public static string[] NamsList = { "Ahmad", "Muhamd", "Yusuf", "Ibraim", "Fadi" };
        public static string[] WeaponList = { "M16","AK47"};
        public static void InitEnwmy(string type, int ammount)
        {
            for (int i = 0; i < ammount; i++)
            {
                EnemyList.Add(Creation(type));
            }
        }

        private static Enemy Creation(string type)
        {
            string codeName = ChoiceName()[0].ToString();
            switch (type)
            {
                case "Armed":
                    WeaponShoot weapon = WeaponFactory.InitWeapon(ChoiceTypeWeapon(), 1);
                    return new EnemyArmed(ChoiceName(), weapon);
                case "Zomb":
                    return new EnemyZombi(ChoiceName(), "Fly");
                default:    
                    return new Enemy(ChoiceName());
            }
            return null;
        }
        static private string ChoiceName()
        {
            Random random = new Random();
            string myName = NamsList[random.Next(NamsList.Length)];
            return myName;
        }   
        static private string ChoiceTypeWeapon()
        {
            Random random = new Random();
            string myType = WeaponList[random.Next(WeaponList.Length)];
            return myType;
        }   
    }
}