namespace Commandos.Models
{
    public class Stone : Weapon, IBreakable
    {
        public Random random = new Random();
        public int NumBeats = 5;
        public string Status = "whole";
        public int Weight;
        public int NumSoFar = 0;
        public Stone(int weight) : base("Stone", "Isr") { }
        public void PrintStatus()
        {
            System.Console.WriteLine("status" + Status);
        }
        public void UpdateNumBeating()
        {
            NumBeats --;
            NumSoFar ++;
        }

        public void PrintCurrentBeatsAmount()
        {
            System.Console.WriteLine(NumBeats);
            System.Console.WriteLine("Number of hits so far " + NumSoFar);
        }
    }
}