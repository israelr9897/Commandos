namespace Commandos.Models
{
    public class EnemyArmed : Enemy
    {
        public WeaponShoot WeaponType;
        public EnemyArmed(string name, WeaponShoot weaponType) : base(name)
        {
            WeaponType = weaponType;
        }

        public void Shoot()
        {
            System.Console.WriteLine("Boooom");
        }

    }
}