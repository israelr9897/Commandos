namespace Commandos.Models
{
    public class M16 : WeaponShoot
    {
        public M16() : base("M16", "COLD", 29) { }
        public void ToStep()
        {
            System.Console.WriteLine("Weapon Step");
        }
    }
}