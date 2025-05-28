namespace Commandos.Models
{
    interface IBreakable
    {
        public void PrintStatus();
        public void UpdateNumBeating();
        public void PrintCurrentBeatsAmount();
    }
}