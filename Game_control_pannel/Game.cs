
using Testtt_1;
using player;
using enemy;

namespace Game{


    class Difficulty{
        public static int dif_1 = 12;
        public static int dif_3 = 20;
        
        public static void Global_difficulty(){

            switch(menu.option){
                case 1:

                Player.health = 5;

                //enemy attriutes
                // Wolf
                Enemy_Health.Wolf_Damage -= 2;
                Enemy_Health.Wolf_miss_chances += 50;
                Enemy_Health.Wolf_Health -= 15;

                //Ogre
                Enemy_Health.Ogre_dmg -= 5;
                Enemy_Health.Ogre_miss_chances += 30;
                Enemy_Health.Ogre_Health -= 30;

                //Bandits
                Enemy_Health.Bandits_dm -= 5;
                Enemy_Health.Bandits_miss_chances += 40;
                Enemy_Health.Bandits_health -= 30;

                //Troll
                Enemy_Health.Troll_default_dmg -= 10;
                Enemy_Health.Troll_miss_chances += 20;
                Enemy_Health.Troll_Health -= 30;

                //Sorcerer
                Enemy_Health.Dark_sorcerer_dmg -= 10;
                Enemy_Health.Dark_sorcerer_miss_chances += 30;
                Enemy_Health.Dark_sorcerer_health -= 30;
                
                //Dragon
                Enemy_Health.Dragon_default_dmg -= 10;
                Enemy_Health.Dragon_miss_chances += 60;
                Enemy_Health.Dragon_health -= 40;
                Enemy_Health.can_breathe_fire = false;
                break;


                case 2: Player.health = 3;  break; // default values 

                case 3: 

                Player.health = 3;

                //Wolf
                 Enemy_Health.Wolf_Damage += 20;
                Enemy_Health.Wolf_miss_chances -= 10;
                Enemy_Health.Wolf_Health += 15;

                //Ogre
                Enemy_Health.Ogre_dmg += 10;
                Enemy_Health.Ogre_miss_chances-= 30;
                Enemy_Health.Ogre_Health += 10;

                //Bandits
                Enemy_Health.Bandits_dm += 20;
                Enemy_Health.Bandits_miss_chances -= 5;
                Enemy_Health.Bandits_health += 20;

                //Troll
                Enemy_Health.Troll_default_dmg -= 10;
                Enemy_Health.Troll_miss_chances -= 20;
                

                //Sorcerer
                Enemy_Health.Dark_sorcerer_dmg += 20;
                Enemy_Health.Dark_sorcerer_miss_chances -= 15;
                Enemy_Health.Dark_sorcerer_health += 20;
                
                //Dragon
                Enemy_Health.Dragon_dm += 40;
                Enemy_Health.Dragon_miss_chances -= 7;
                Enemy_Health.can_breathe_fire = true;
                break;

                default: menu.option = 3; break;
            }
        }



        // Player score updates
        public static int Global_score = 0;
        public static void Score_Display(){

        } 

        // Updates and display the remaining game health of the player
        public static void Player_Health_Chances(){ 

        }

        public static void HighScoreSystemm(){
            
        }

        
    }
}