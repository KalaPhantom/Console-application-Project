
namespace player
{
      class Player{ // - > Variables for  

        public static string Player_name; // Player name 
        public static int health = 5; // Health

        public static int battle_health =  50;
        public static int sanity; // A random ghost will appear on the game draining all of the remaining sanity 
        public static int damage =10; // Out of bound in the goal but still in progress

        public static bool Pl_alive =true;
        public static bool Is_pl_poisoned = false; 

        public static int Slained_enemy_count = 0;
        public static int Player_score = 0;
        public static int Flee_count = 0;
        public static int Loss_count = 0;



        public static int Global_difficulty_multiplyer; 
    }
    
}
