namespace Commandos.Models
{
    public class Weapon 
    {
        public string Name;
        public string Manufacturer;

        public Weapon(string name, string manufacturer)
        {
            Name = name;
            Manufacturer = manufacturer;
        }
    }

}