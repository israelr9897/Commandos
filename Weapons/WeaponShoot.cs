namespace Commandos.Models
{
    public class WeaponShoot
    {
        public string Name;
        public string Manufacturer;
        public int NumOfBalls;

        public WeaponShoot(string name, string manufacturer, int numOfBalls)
        {
            Name = name;
            Manufacturer = manufacturer;
            NumOfBalls = numOfBalls;

        }

        public void UpdateBullets()
        {
            NumOfBalls -= 1;
        }
        public void PrintShoot()
        {
            System.Console.WriteLine("Booooom");
        }

    }

}