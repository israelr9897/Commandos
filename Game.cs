namespace Commandos.Models
{
    public class Game
    {
        private static Game Status = null;
        private static int NumCommandos;
        private static int NumWeapons;
        private static int NumEnemy;
        private static string[] TypeCommando = { "Air", "Sea", "Regular" };
        private static string[] TypeWeapon = { "M16", "AK47" };
        private static string[] TypeEnemy = { "Armed", "Zombi" };
        private static Random random = new Random();

        private Game(int numCommandos, int numWeapons, int numEnemy)
        {
            NumCommandos = numCommandos;
            NumWeapons = numWeapons;
            NumEnemy = numEnemy;
        }

        public static void InitGame(int numCommandos, int numWeapons, int numEnemy)
        {
            Game game = new Game(numCommandos, numWeapons, numEnemy);
            Status = game;
            if (Status == null)
            {
                CommandoFactory.InitCommando(TypeCommando[random.Next(3)], NumCommandos);
                WeaponFactory.InitWeapon(TypeWeapon[random.Next(3)], numWeapons);
                EnemyFactory.InitEnwmy(TypeEnemy[random.Next(3)], NumEnemy);
            }
            else
            {
                Status = game;
            }
        }
    }
}