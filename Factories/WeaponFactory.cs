namespace Commandos.Models
{
    public class WeaponFactory
    {
        public static List<Weapon> WeaponObjList = new List<Weapon>();
        public static Weapon InitWeapon(string type, int ammount)
        {
            for (int i = 0; i < ammount; i++)
            {
                WeaponObjList.Add(Creation(type));
            }
            return Creation(type);
        }

        public static Weapon Creation(string type)
        {
            Random random = new Random();
            switch (type)
            {
                case "M16":
                    return new M16();
                case "AK47":
                    return new AK47();
                case "Ston":
                    return new Stone(random.Next(1, 50));
            }
            return null;
        }
    }
}