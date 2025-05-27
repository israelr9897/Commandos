namespace Commandos.Models
{
    public class Weapon
    {
        public string Name;
        public string Manufacturer;
        public int NumOfBalls;

        public Weapon(string name, string manufacturer, int numOfBalls)
        {
            Name = name;
            Manufacturer = manufacturer;
            NumOfBalls = numOfBalls;

        }

        public void Shoot()
        {
            NumOfBalls -= 1;
            System.Console.WriteLine("Shoooottttt");
        }
    }

}