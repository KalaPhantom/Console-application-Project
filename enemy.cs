using player;


namespace enemy{ // sets the enemy damage
    class Enemy{
        //public static bool ene_dmg = false;
        public static void enemy_damage(){
            //progress_bar.healthbar(); // This is temporary

            Player.health -= 5;
        }
        public static void Ogre(){
            Player.health -= 10;
        }
        public static void Wolf(){
            Player.health -= 15;
        }
        public static void Ghost(){
            Player.sanity -= 20;
        }
        
        
    }
}