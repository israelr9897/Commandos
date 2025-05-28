namespace Commandos.Models
{
    public class EnemyArmed : Enemy
    {
        public Weapon WeaponType;
        public EnemyArmed(string name, Weapon weaponType) : base(name)
        {
            WeaponType = weaponType;
        }

        public void Shoot()
        {
            System.Console.WriteLine("Boooom");
        }

    }
}