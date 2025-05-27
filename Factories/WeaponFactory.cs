namespace Commandos.Models
{
    public class WeaponFactory
    {
        public static List<WeaponShoot> WeaponObjList = new List<WeaponShoot>();
        public static WeaponShoot InitWeapon(string type, int ammount)
        {
            for (int i = 0; i < ammount; i++)
            {
                WeaponObjList.Add(Creation(type));
            }
            return Creation(type);
        }

        public static WeaponShoot Creation(string type)
        {
            WeaponShoot weapon;
            switch (type)
            {
                case "M16":
                    return weapon = new M16();
                case "AK47":
                    return weapon = new AK47();
            }
            return null;
        }
    }
}