namespace Commandos.Models
{
    public class AK47 : WeaponShoot
    {
        public AK47() : base("AK47", "KALASHNIKOV", 30) { }
        public void ToStep()
        {
            System.Console.WriteLine("To release a prisoner");
        }
    }
}