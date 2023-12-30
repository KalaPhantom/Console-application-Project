using player;


namespace enemy{ // sets the enemy damage
    class Enemy{

        public static bool En_alive = true;
        //public static bool ene_dmg = false;
       
    }
    class Enemy_Health{

        //Wolf
       public static int Wolf_Health = 30;
       public static int Wolf_Damage = 5;
       public static int Wolf_default_dmg = 30;
       public static int Wolf_dodge_rate = 50;
       public static int Wolf_attack_rate = 50;
       public static int Wolf_miss_chances = 10;

        //troll
       public static int Troll_Health = 70;
       public static int Troll_Dmg = 20;
       public static int Troll_default_dmg = 20;
       public static int Troll_dodge_rate =40;
       public static int Troll_attack_rate = 60;
       public static int Troll_miss_chances = 40;

       // Mage
       public static int Dark_sorcerer_health = 50;
       public static int Dark_sorcerer_dmg = 20;
       public static int Dark_sorcerer_default_dmg = 20;
       public static int Dark_sorcerer_dodge_rate = 30;
       public static int Dark_sorcerer_attack_rate = 70;
       public static int Dark_sorcerer_miss_chances = 20;

       //Ogre
       public static int Ogre_Health = 60;
       public static int Ogre_dmg = 15;
       public static int Ogre_default_dmg = 25;
       public static int  Ogre_dodge_rate = 20;
       public static int Ogre_attack_rate = 70;
       public static int Ogre_miss_chances = 40;


       //bandits 
       public static int Bandits_health = 60;
       public static int Bandits_dm = 10;
       public static int Bandits_default_dmg = 10;
       public static int Bandits_dodge_rate =30;
       public static int Bandits_attack_rate = 70;
       public static int Bandits_miss_chances = 10;

       //Dragon
       public static int Dragon_health = 80;
       public static int Dragon_dm = 20;
       public static int Dragon_default_dmg = 40;
       public static int Dragon_dodge_rate =30;
       public static int Dragon_attack_rate = 70;
       public static int Dragon_miss_chances = 10;
       public static bool can_breathe_fire = true;

        public static void Res_en(){
        Wolf_Health = 30;
        Wolf_Damage = 5;
       Wolf_default_dmg = 30;
       Wolf_dodge_rate = 50;
       Wolf_attack_rate = 50;
       Wolf_miss_chances = 10;

        //troll
       Troll_Health = 70;
       Troll_Dmg = 20;
       Troll_default_dmg = 20;
       Troll_dodge_rate =40;
       Troll_attack_rate = 60;
       Troll_miss_chances = 40;

       // Mage
       Dark_sorcerer_health = 50;
       Dark_sorcerer_dmg = 20;
        Dark_sorcerer_default_dmg = 20;
       Dark_sorcerer_dodge_rate = 30;
       Dark_sorcerer_attack_rate = 70;
       Dark_sorcerer_miss_chances = 20;

       //Ogre
       Ogre_Health = 60;
       Ogre_dmg = 15;
       Ogre_default_dmg = 25;
       Ogre_dodge_rate = 20;
       Ogre_attack_rate = 70;
       Ogre_miss_chances = 40;


       //bandits 
       Bandits_health = 60;
       Bandits_dm = 10;
        Bandits_default_dmg = 10;
       Bandits_dodge_rate =30;
       Bandits_attack_rate = 70;
       Bandits_miss_chances = 10;

       //Dragon
       Dragon_health = 80;
       Dragon_dm = 20;
       Dragon_default_dmg = 40;
       Dragon_dodge_rate =30;
       Dragon_attack_rate = 70;
       Dragon_miss_chances = 10;
       


    }

    }

   


}