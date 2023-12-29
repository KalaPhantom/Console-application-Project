
using System.Runtime.CompilerServices;
using System.Security.Policy;
using enemy;
using player;
using Selection;
using Simulations;
using tesst_1;
using Highscore;
using Sound;


/*

IMPORTANT NOTE

Use the methods: 

    Dlg_Resetter() - for resetting the consol layout
    sel_1() - this is reserved for the introductory dialogue 
    sel_2() - in-line selecttion -> can take 4 arguments
    sel_3() - horizontal selection -> can take 4 arguments

    health_bar.Battle() - calls for default battle layout // Already included in the  -->   BattleSimulations.battle1()
    BattleSimulations.battle1() is called when a battle has to be settled in a story  --> // Enemy-- Where a = for the enemy health ||| b is for the enemy damage ||| c is for the enemy dodge rate ||| d is for the enemy attack rate cc is for the name





*/





namespace Story{


    class story{
        public static int Secret_ending_count;
 
        public static bool static_story1 = true; // Map is accepted -
        public static bool static_story2;
        public static bool static_story3 ; // The herron is taken or not
        public static bool static_story5; // Gathered supplies - Crucial if not gathered - the player never returned safely

        public static bool epilogue_1; // The Escapist's ending --> if the player successfully flee to battles multiple times 
        public static bool epilogue_2; // The dragon slayer --> if the player successfully slains the dragon
        public static bool epilogue_3; // The model knight --> if he returned the herron 
        public static bool epilogie_4; // The dwarf

        public static bool The_return = false; // if the player play more than once 


        // Contains the resent player score
        

        

        


        public static int pos_t;
        public static int pos_w; 

        public static int battle_xp;  // Acquired from the batlle
        public static int story_xp; // acquired from the story 
        public static int story_xp_add; // Acquired XP score in the momment
        


        public static void XP(){
            (int x, int y) = Console.GetCursorPosition();
            Console.SetCursorPosition(x , y);
            anima.anima1($"\n\n\t\t\t\t XP: +\x1b[34m{story_xp_add}\x1b[0m");
            story_xp += story_xp_add;
            
            
        }

        public static void Dlg_reseter(){ // reset and initiate the dialogue frame
            Console.Clear();
            layout.border_layout();
            Console.SetCursorPosition(3,3);
        }
        public static void Health_reset(){
            Player.battle_health = 50;
        }
        public static void Press(){ // Ask for the user input. to continue the story even further 
            
            anima.anima1("\n\t\t\t\t\t\x1b[1mPress any key to continue. . . . . . . . . . . .\x1b[0m ");
            Console.ReadKey();

        }
        public static void Continue(){
            (pos_w, pos_t) = Console.GetCursorPosition();
            Console.SetCursorPosition(50,pos_t + 3);
            Console.WriteLine(">> Continue");
            Console.ReadKey();
            
        }
        public static void battle_start(){ // Called when an enemy encounter happens 
            Dlg_reseter();
            Console.SetCursorPosition(36,4);
            anima.anima1("Begin Battle > > > > > ");
            Console.WriteLine();
            Press();
            layout.Battle_layout();
        }

        public static void Tutorials(){

            if(Player.play_count > 0){
                Console.Clear(); layout.border_layout();
                anima.anima2("Skip the Reminder Dialogues...?");
                system_selection.sel_2("Yes","No");

                if (system_selection.sel_option == 2){
                   
                    Console.Clear(); layout.border_layout(); 
                     Console.ForegroundColor = ConsoleColor.Yellow;
                    anima.anima1("Hi there adventurer.........."); Thread.Sleep(1000); Console.Clear(); layout.border_layout();
                    anima.anima1("Before we begin..... here is just a few reminders......."); Thread.Sleep(1500); Console.Clear(); layout.border_layout();
                    anima.anima1("This game contains a very short story. Expect a quick gameplay........"); Thread.Sleep(1000); Console.Clear(); layout.border_layout();
                    anima.anima1("\tUse the Arrow keys on your keyboard to navigate throughout the choices in the story \n\tPress the enter key to select....."); Continue(); Console.Clear(); layout.border_layout();
                    anima.anima1("Be careful on your choices, it will lead to a different path......"); Continue();Console.Clear(); layout.border_layout();
                    anima.anima1("Goodluck... and enjoy"); Thread.Sleep(500); anima.anima1("\n\n\tPress any key to continue to your journey..."); Console.ReadKey();
                    Console.ResetColor();
                }
            }
            else{
                
                Console.Clear(); layout.border_layout(); 
                Console.ForegroundColor = ConsoleColor.Yellow;
                anima.anima1("Hi there adventurer.........."); Thread.Sleep(1000); Console.Clear(); layout.border_layout();
                anima.anima1("Before we begin..... here is just a few reminders......."); Thread.Sleep(1500); Console.Clear(); layout.border_layout();
                anima.anima1("This game contains a very short story. Expect a quick gameplay........"); Thread.Sleep(1000); Console.Clear(); layout.border_layout();
                anima.anima1("\tUse the Arrow keys on your keyboard to navigate throughout the choices in the story \n\tPress the enter key to select....."); Continue();Console.Clear(); layout.border_layout();
                anima.anima1("Be careful on your choices, it will lead to a different path......"); Continue();Console.Clear(); layout.border_layout();
                anima.anima1("Goodluck... and enjoy"); Thread.Sleep(500); anima.anima1("\n\n\tPress any key to continue to your journey..."); Console.ReadKey();
                Console.ResetColor();

            }

           

        }

        public static void Intro1(){
            Console.SetCursorPosition(7,15);
            Console.Clear();
            layout.border_layout();
            anima.anima1("In the mystical land of Rohann, a realm shrouded in ancient magic and steeped in mythical history ");
            Continue();

            Console.SetCursorPosition(7,15);
            Console.Clear();
            layout.border_layout();
            anima.anima1("Adventurers from far and wide gather to embark on epic quests, unravel mysteries, and shape their destinies");
            Continue();

            Console.Clear();
            layout.border_layout();
            Console.SetCursorPosition(7,15);
            anima.anima1("However.............");
            Continue();


            Console.Clear();
            layout.border_layout();
            Console.SetCursorPosition(7,15);
            anima.anima1("The Kingdom of Rohann caught in a curse of the Corrupted Prism Dannan"); // Yess this is a terraria reference
            Continue();

            Console.Clear();
            layout.border_layout();
          
            (int a , int b) = Console.GetCursorPosition(); 
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(a,3);
            Console.WriteLine("\t\t\t\t                 |ZZzzz");
            Console.WriteLine("\t\t\t\t                 |");
            Console.WriteLine("\t\t\t\t    |ZZzzz      /^\\            |ZZzzz ");
            Console.WriteLine("\t\t\t\t    |          |~~~|           |");
            Console.WriteLine("\t\t\t\t    |        |^^^^^^^|        /   ");
            Console.WriteLine("\t\t\t\t   /^        |[]+    |       |~~~|");
            Console.WriteLine("\t\t\t\t|^^^^^^^|    |    +[]|       |   |");
            Console.WriteLine("\t\t\t\t|    +[]|____________________|^^^|");
            Console.WriteLine("\t\t\t\t|+[]+   |~~~~~~~~~~~~~~~~~~|    +[]|");
            Console.WriteLine("\t\t\t\t|       |  []   /^\\  []   |+[]+   |");
            Console.WriteLine("\t\t\t\t|   +[]+|  []  || ||  []   |   +[]+|");
            Console.WriteLine("\t\t\t\t|[]+    |      || ||       |[]+    |");
            Console.WriteLine("\t\t\t\t|_______|------------------|_______|");
            Console.ResetColor();

            Console.SetCursorPosition(7,17);
            anima.anima1("People..."); Thread.Sleep(500); anima.anima1("They died of diseases"); Thread.Sleep(500); anima.anima1("\n\tFarmlands were not able to produce crops, Trees and plants starts to wither and some other people\n\talready left the kingdom");
            Continue();

             Console.Clear();
              layout.border_layout();
             Console.SetCursorPosition(7,14);
             anima.anima1("With the Kindom ruler being desperate, He address his people");
             Continue();

             Console.Clear();
             layout.border_layout();
             Console.SetCursorPosition(7,14);
             anima.anima1("\" Whoever are the able Men or Women of this kingdom, must participate on ending this curse\" - The King said ");
             Continue();

             Console.Clear();
             layout.border_layout();
             Console.SetCursorPosition(7,14);
             anima.anima1("The Sorcerers of the Kindom pointed out, \"A particular magical artifact is what the kingdom need \" ....."); Continue();
             Console.Clear();
             layout.border_layout();
             Console.SetCursorPosition(7,17);
             anima.anima1("The Lost Herron. . . . . .");
             Continue();

             Console.Clear();
             layout.border_layout();
             Console.SetCursorPosition(7,14);
             anima.anima1("So you"); Thread.Sleep(300); anima.anima1(" ,an able man, presents yourself as a volounteer");
             Continue();

            Console.Clear();
             layout.border_layout();
             Console.SetCursorPosition(7,14);
             anima.anima1("So Then . . . . . . .");
             Continue();

            

        }

        public static void Dialogue_1() // This is the welcoming dialogue
        { 
            
            Console.Clear();
           
            layout.border_layout();
            anima.anima1($"On the cheers of the crowd, A hero by the name of {Player.Player_name} enters the stage" );
            layout.def_layout();
            Console.SetCursorPosition(4,5);
            anima.anima1("With all of the cheering crowd and embracing glory, you go out on your journey");
            Console.SetCursorPosition(4,6);
            anima.anima1("Bearing the promise of having glory, and returning as a hero");
            
            Continue();
      
         
        }
        public static void Dialogue_2(){ // Base XP score 10 to 20
            string a = $"\tYou find yourself in the quaint village of Stellar,\n\tsurrounded by towering medieval structures and cobbled streets. \n\tThe air is filled with the aroma of freshly baked bread, and distant sounds \n\tof clashing swords echo from the training grounds. \n\tAs you stroll through the marketplace, an old beggar approaches you,\n\thanding you a weathered map";
            Dlg_reseter();
            anima.anima1(a);
            (int wi , int h) =Console.GetCursorPosition();
            Console.SetCursorPosition(40,h+3);
            (system_selection.c_with, system_selection.c_top ) = Console.GetCursorPosition();
            system_selection.sel_option = 1;
            system_selection.sel_1();

            switch (system_selection.sel_option){
                case 1: Console.Clear(); layout.border_layout(); anima.anima1("\n\n\t\t\tYou accept the map and go on your ways"); story_xp_add = 20; XP(); break;
                case 2: Console.Clear(); layout.border_layout();anima.anima1("\n\n\t\t\t\tYou Refuse the map ");break;
                case 3: Console.Clear(); layout.border_layout();anima.anima1("\n\n\t\t\t\tYou go on your ways "); break;
            }
            Console.WriteLine("");
            Press();
            Console.Clear();
            layout.border_layout();

            if (system_selection.sel_option != 1){
                anima.anima1("\n\n\n\t\t . Refusing the map, you find yourself with little to do in the village, \x1b[31mgrowing weary\x1b[0m. \n\tIt forces you to go back to the old beggar and accept the map."); story_xp_add = 10; XP();
                Press();
            }

        }
        public static void Dialogue_3(){
            Random rnd_situation = new Random();
            int a = rnd_situation.Next(1,100);


            Console.Clear();
            layout.border_layout();
            system_selection.sel_option = 1;
            anima.anima1("\t\tAccepting the map, you discover it leads to the legendary Lost Herron \n\thidden deep within the treacherous Darkwood Forest.");
            system_selection.sel_3("Gather supplies from the village before embarking on the journey","Head straight to the Darkwood Forest without any preparation");
            switch(system_selection.sel_option){
                case 1: Console.WriteLine("\n\n\t\tYou gathered the necessary supplies and go on your ways"); Console.Clear(); layout.border_layout(); story_xp_add = 30; XP(); break;
                case 2: 
                    switch(a > 50? "Success" : "Fail"){
                        case "Success":  break; // Will not affect the ending
                        case "Fail": break; // Will lessens the players Health and affects the ending

                    }
                    Console.Clear(); layout.border_layout();
                    anima.anima1("\n\n\t\t\tWith Confidence - You decide to go ");story_xp_add = 10; XP();break; 
            }
            Continue();
           
        }

        public static void Dialogue_4(){
            Console.Clear();
            layout.border_layout();
            anima.anima1("\n\n\tAs you delve into the heart of Darkwood, a forked path presents itself");
            system_selection.sel_option = 1;
            system_selection.sel_3("Take the well-trodden path","Venture into the dense thicket");

            Random rnd = new Random();
            int chances_random = rnd.Next(1,100);


            if (system_selection.sel_option == 1){
                switch (chances_random < 90? "avoid": chances_random > 90? "battle": "avoid"){
                    case "avoid":Console.Clear(); layout.border_layout(); anima.anima1("\n\t\t\tyou passed safely"); story_xp_add = 40; XP(); break;
                    case "battle":Console.Clear(); layout.border_layout();anima.anima1("\n\t\t\t\u001b[31mYou enecoutered a wolf\u001b[0m"); Continue();  battle_start(); Batte_Simulation.battle1(Enemy_Health.Wolf_Health,Enemy_Health.Wolf_Damage,Enemy_Health.Wolf_dodge_rate, Enemy_Health.Wolf_attack_rate,Enemy_Health.Wolf_miss_chances,"Wolf");
                    break;
                }
            }
            else if (system_selection.sel_option == 2){
                switch (chances_random < 90? "battle": chances_random > 90? "avoid": "battle"){
                    case "avoid":Console.Clear(); layout.border_layout(); anima.anima1("you passed safely"); Continue(); break;
                    case "battle":Console.Clear(); layout.border_layout(); anima.anima1("\n\t\t\t\u001b[31mYou enecoutered a wolf\u001b[0m"); Continue(); battle_start(); Batte_Simulation.battle1(Enemy_Health.Wolf_Health,Enemy_Health.Wolf_Damage,Enemy_Health.Wolf_dodge_rate, Enemy_Health.Wolf_attack_rate,Enemy_Health.Wolf_miss_chances,"Wolf");
                    break;
                }

            }
            // Battle happens // fight with a wolf
            Player.battle_health = 50; // Reset
            Batte_Simulation.is_pl_defeated = false;

            Continue();
        }

        public static void Dialogue_5(){
            Dlg_reseter();

            switch (system_selection.sel_option){ // Need to finish the function for the battle 
                case 1: Dlg_reseter(); anima.anima1("Chossing the \u001b[33mwell-trodden Path, you encountered a mystirious hooded figure\u001b[0m \n\n\t You have no Idea if it is Hostile ");  break;
                case 2: Dlg_reseter(); anima.anima1("Choosing the \u001b[33m Dense ticket path, you encountered a mystirous hooded figure\u001b[0m \n\n\t You have no idea if it is Hostile"); break;
            }

            system_selection.sel_3("Approach the figure cautiously","Avoid the figure and continue on your way");
         
            switch (system_selection.sel_option){
                case 1: Console.Clear(); layout.border_layout();anima.anima1("\n\n\t\tYou approach the figure cautiously"); Continue(); Console.Clear(); layout.border_layout(); story_xp_add = 30; XP(); break; //  friendly _ Easy // Normal - Random
                case 2: Console.Clear(); layout.border_layout(); anima.anima1("\n\n\t\tAvoiding the hooded figure, \n\t\t \u001b[31myou encountered a magic troll\u001b[0m"); Continue(); battle_start();Batte_Simulation.battle1(Enemy_Health.Troll_Health,Enemy_Health.Troll_Dmg,Enemy_Health.Troll_dodge_rate,Enemy_Health.Troll_attack_rate, Enemy_Health.Troll_miss_chances, "Magic Troll");
            break;
            }
            Press();

        }
        public static void Dialogue_5_5(){
             Dlg_reseter();
           
             
             if (Batte_Simulation.is_pl_defeated == true && system_selection.sel_option != 1){
                anima.anima1("Recovering from the battle, the mysterious hooded figure from the distance vanished");  story_xp_add = 5; XP();
                 
             }
             else{
                  anima.anima1("The Figure approach.... they reveal themselves as a dark sorcerer, offering you a power and health");
                  system_selection.sel_option = 1;
                  system_selection.sel_2(" Accept","Decline"); 
             }
           
             if(system_selection.sel_option == 1 && Batte_Simulation.is_pl_defeated != true){ // depends on the difficulty
                Player.damage += 20; anima.anima1("\n\n\t\t\t\tDMG +20"); story_xp_add = 30; XP();

             }
             else if (system_selection.sel_option == 2 && Batte_Simulation.is_pl_defeated != true){
                Console.Clear(); layout.border_layout(); anima.anima1("\u001b[31mThe Sorcerer decide to fight you\u001b[0m");
                Batte_Simulation.battle1(Enemy_Health.Dark_sorcerer_health, Enemy_Health.Dark_sorcerer_dmg, Enemy_Health.Dark_sorcerer_dodge_rate,Enemy_Health.Dark_sorcerer_attack_rate,Enemy_Health.Dark_sorcerer_miss_chances, "Dark Sorcerer");
             }
             Continue();

             Batte_Simulation.is_pl_defeated = false;

        }
        public static void Dialogue_7(){
            system_selection.sel_option = 1;
            Dlg_reseter();
            anima.anima1("Continuing through Darkwood, you stumble upon a rickety bridge spanning a chasm.");
            system_selection.sel_2("Cross the bridge carefully", "Look for an alternative route"); // -> Wrong decision will let the player to encounter am ogre // or a bridge will collapse

            Random random_situation = new Random();
            switch (system_selection.sel_option){
                case 1:// -------
                Console.Clear(); layout.border_layout();
                anima.anima1("\n\n\t\t You carefully thread the bridge");  Continue();
                int situation1 = random_situation.Next(1,100);

                switch (situation1 > 50? "battle" : situation1 <= 20? "collapse" :"safe" ){
                    case "safe": Console.Clear(); layout.border_layout(); anima.anima1("\n\n\t\t You managed to cross to the bridge"); story_xp_add = 30; XP(); Continue();break; //The bridge stay intacted 
                    case "battle":Console.Clear(); layout.border_layout();anima.anima1("\u001b[31mAs you are crossing on the bridge, an Ogre aproaches\u001b[0m"); Continue(); Batte_Simulation.battle1(Enemy_Health.Ogre_Health,Enemy_Health.Ogre_dmg,Enemy_Health.Ogre_dodge_rate,Enemy_Health.Ogre_attack_rate,Enemy_Health.Ogre_miss_chances,"Ogre"); break; // You encountered an ogre
                    case "collapse": Console.Clear(); layout.border_layout(); Player.health -= 1 ; anima.anima1($"\n\n\t\t \u001b[32mThe Bridge Collapsed........\u001b[0m \n\n\t\t\t You have \u001b[33m{Player.health} \u001b[0mhealth chances left"); Continue(); if(Player.health > 0){Console.Clear(); layout.border_layout(); anima.anima1("But you manage to get up and continue on your ways");} Console.WriteLine(); break;// The bridge collapse
                    }
                break;

                case 2: // -----
                Console.WriteLine("\n\n\t\t You look for the alternative route"); 
                Random random_situation2 = new Random();
                int situation2 = random_situation2.Next(1,100);

                switch (situation2 > 70? "Safe" : "battle"){
                    case "Safe": Console.Clear();layout.border_layout();anima.anima1("\n\n\t\tYou successfully find an alternative route");  story_xp_add = 30; XP(); break;
                    case "battle":
                    Console.Clear();
                    layout.border_layout();
                    anima.anima1("\n\n\t\t \u001b[31mYou encoutered an Ogre . . . . . . . \u001b[0m"); Continue();
                    battle_start();
                    Batte_Simulation.battle1(Enemy_Health.Ogre_Health,Enemy_Health.Ogre_dmg,Enemy_Health.Ogre_dodge_rate,Enemy_Health.Ogre_attack_rate,Enemy_Health.Ogre_miss_chances,"Ogre");
                    break;
                }
                break;
            }
            
            Press();

        }
        public static void Dialogue_8(){
            // Need of the use of switch 
            // The Dialogue 8 and 7 is interconnected
            Dlg_reseter();
          
            switch(system_selection.sel_option){
                case 1: anima.anima1("On the other side , you see a group of bandits holding hostage a dwarf"); break;
                case 2: anima.anima1("Threading through the alternative route, you see a group of bandits \n\t holding a dwraf as their hostage"); Continue(); break;

            }
            system_selection.sel_2("Save the dwarf", "Don't save the dwarf");
            if (system_selection.sel_option == 1){
                anima.anima1("\n\n\t\t\tYou decided to save the hostage ........");
                // battle of the bandits
                Batte_Simulation.battle1(Enemy_Health.Bandits_health, Enemy_Health.Bandits_dm,Enemy_Health.Bandits_dodge_rate,Enemy_Health.Bandits_attack_rate,Enemy_Health.Bandits_miss_chances,"Group of bandits");
                Console.ForegroundColor = ConsoleColor.Yellow;
                if(Batte_Simulation.is_pl_defeated == true){epilogie_4 = false;} else {epilogie_4 = true;}
                if (Batte_Simulation.is_pl_defeated == false && epilogie_4 == true){
                    Console.Clear();
                    layout.border_layout();
                    anima.anima1("\n\n\t\tWith all of the bandits being defeated, The dwarf cheerfully thank you \n\n\t\tHanding you a Health Potion");
                    Continue();
                    Console.Clear();
                    layout.border_layout();
                    anima.anima1("\n\n\t\tWith the Dwarf's Talkative nature, the dwarf starts to tell stories \n\n\t\tAs you consume your health potion, The dwarf start to mention its knowledge about the lost herron");
                    Continue();
                    Console.Clear();
                    layout.border_layout();
                    anima.anima1("\n\n\t\t\"You must be an adventurer \" The dwarf mutered");

                    system_selection.sel_option = 1;
                    system_selection.sel_3("\"Uhmm .... Yes\"", "\"None of your business....\"");
                    if (system_selection.sel_option ==1 ){
                        Console.Clear();
                        layout.border_layout();
                        anima.anima1("\n\n\t\t\"You must be one of them............ Those adventurers who seek for the Herron but fails\"");
                        Thread.Sleep(1000); Console.Clear(); layout.border_layout();
                        anima.anima1("\n\n\t\t \"But Hey.......");Thread.Sleep(500); anima.anima1("\"\n\t\t Here's my map for the Herron, I know exactly where it is \n\t\t I'm just a weak dwarf to go to that cave and take it......\""); Continue();
                        Console.Clear();
                        layout.border_layout();
                        anima.anima1("\n\n\t\tHe hands you a map and bid his farewell......."); Continue();
                        Console.Clear();
                        layout.border_layout();
                        anima.anima1("\n\n\t\t\"And another thing adventurer\"........."); Continue(); Console.Clear();
                        layout.border_layout();
                        anima.anima1("\n\n\t\t\"Beware of the dragon . . . . . . . .");  story_xp_add = 70; XP(); Continue();

                    }
                    else if (system_selection.sel_option == 2){
                        Console.Clear();
                        layout.border_layout();
                        anima.anima1("\n\n\t\t\"Oww....");Thread.Sleep(500);anima.anima1("\n\n\t\t\"Never mind me asking......."); Continue();
                        Console.Clear();
                        layout.border_layout();
                        anima.anima1("\n\n\t\tA long pause occur, The dwarf is silenced.......... "); Continue();
                        Console.Clear();
                        layout.border_layout();
                        anima.anima1("\n\n\t\t Then both of you decide to part ways........ "); Continue();
                        Console.Clear();
                        layout.border_layout();
                        anima.anima1("\n\n\t\t \"Slain that dragon adventurer........\" The dwarf mutered at a distance \n\t\tYou have no clue  what he just said");  story_xp_add = 30; XP(); Continue();

                    }
                }
                else {Batte_Simulation.is_pl_defeated = false; Batte_Simulation.is_player_fled = false;}

            }
            else{
                anima.anima1("You escape the scene ............");  story_xp_add = 10; XP();
            }
            Console.ResetColor();
           
        }

        public static void Dialogue_10(){ // Death by poision -- epilogue
            Dlg_reseter();
            anima.anima1("After that encounter, you reach the Enchanted Cave where the Herron is rumored to rest.");
            system_selection.sel_option = 1;
            system_selection.sel_2("Scout the surroundings before entering", "Enter the cave boldly"); // Wrong choice will lead for the bubby trap with poison lessening the health of the player by 2
            
            switch (system_selection.sel_option){
                case 1: Console.Clear(); layout.border_layout(); anima.anima1("\n\n\t\tYou scouted the area and found a trap . . . . . "); anima.anima1("\n\n\t\t You manage to thread carefully"); story_xp_add = 10; XP();break;
                case 2: Console.Clear(); layout.border_layout();
                anima.anima1("\n\n\t\tWith overwhelming confidence, you decided to eneter to the cave boldy         "); Continue(); Console.Clear(); layout.border_layout();
                anima.anima1("\n\n\t\t CLAANGGG!!!!, A spike trap impaled your feet inflicting poison to your body"); // We can give the player a choice tyo give up - if the player given up - it will give us an immidiete ending  - either the player died of poison, or the player manage to arrive in the nearby town for a posion cure 
                // Poison attribute goes here s
                 story_xp_add = 2; XP();
                 Player.Is_pl_poisoned = true;
                break;

            }

            Press();

        }
        public static void Dialogue_11(){
            Dlg_reseter();
            anima.anima1("Inside the cave, you face a choice between two tunnels");
            system_selection.sel_2("Choose the left tunnel","Choose the right tunnel."); // Must have a randomizer
             story_xp_add = 30; XP();
            Press();

        }
        public static void Dialogue_12(){
            system_selection.sel_option =1;
            Dlg_reseter();
            anima.anima1("After navigating the tunnels, you find yourself in the presence of the Lost Herron");
            system_selection.sel_3("Inspect the surroundings","Reach out and take the Golden Enchannted Herron"); // A minecraft referernce

            Random random_situation = new Random();
            int dragon_appearance = random_situation.Next(1,100);
            Press();

           switch(system_selection.sel_option){

            case 1:////////////////////////////////// --- Inspect the soroundings 
                Console.Clear(); layout.border_layout();

                switch(dragon_appearance > 20? "battle" : "sleep"){
                    case "battle": SfX.Rorr();
                     anima.anima1("As you are inspecting the sorroundings....."); Thread.Sleep(1000);anima.anima1("A dragon emerges from the darkness..."); Continue(); Console.Clear(); layout.border_layout(); battle_start();
                        Console.Clear(); layout.border_layout(); Batte_Simulation.battle1(Enemy_Health.Dragon_health,Enemy_Health.Dragon_dm, Enemy_Health.Dragon_dodge_rate,Enemy_Health.Dragon_attack_rate,Enemy_Health.Dragon_miss_chances,"Dragon");
                        if(Batte_Simulation.is_pl_defeated == true && Player.health > 0){
                            Console.Clear(); layout.border_layout();
                            anima.anima1("With such devastating defeat from the dragon. . . . . "); Thread.Sleep(1000); Console.WriteLine(); anima.anima1("\n\tYou managed to escape. . . . .and take the golden herron "); Continue(); Batte_Simulation.is_pl_defeated = false;  story_xp_add = 10; static_story3 = true; XP(); // initiate epilogue
                        }
                        else if (Batte_Simulation.is_pl_defeated == false && Player.battle_health > 0){
                            Console.Clear(); layout.border_layout(); anima.anima1("With the dragon being defeated........"); Thread.Sleep(1000); Console.WriteLine(); anima.anima1("\tYou manage to take the Golden Herron"); Continue(); static_story2 = true; static_story3 = true;  story_xp_add = 30; XP(); // --> The model knight
                            Dlg_reseter();
                            anima.anima1("\tExiting the Enchanted Cave, you hold the Lost Herron in your hands,\n\tmemories of battles and encounters lingering.\n\tThe amulet around your neck and the rewards collected serve as reminders. \n\tDepending on your choices, you either use the Herron to bring prosperity, \n\tmisuse its power, or return it to the hooded figure");
                            Continue();break;
                        }
                    break;


                    case "sleep": 
                        Console.Clear(); layout.border_layout(); anima.anima1(" You found a sleeping dragon as you inspect your sorroundings....... \n\tYou safely take the Golden Herron and go on your way"); Continue(); epilogue_3 = true;  story_xp_add = 30; XP(); // initiate epilogue
                        Dlg_reseter();
                        anima.anima1("Exiting the Enchanted Cave, you hold the Lost Herron in your hands,\n\tmemories of battles and encounters lingering.\n\tThe amulet around your neck and the rewards collected serve as reminders. \n\tDepending on your choices, you either use the Herron to bring prosperity, \n\tmisuse its power, or return it to the hooded figure");
                        Continue();break;
                    
                }
            break;


            case 2: //////////////////////////////
                    switch(dragon_appearance > 10? "battle" : "take"){
                        case "battle" :
                        Console.Clear(); layout.border_layout();anima.anima1("As you are taking the Golden Herron......."); Thread.Sleep(1000);SfX.Rorr(); anima.anima1("A dragon emerges from the darkness..."); Continue(); Console.Clear(); layout.border_layout(); battle_start();
                        Console.Clear(); layout.border_layout(); Batte_Simulation.battle1(Enemy_Health.Dragon_health,Enemy_Health.Dragon_dm, Enemy_Health.Dragon_dodge_rate,Enemy_Health.Dragon_attack_rate,Enemy_Health.Dragon_miss_chances,"Dragon");
                        if(Batte_Simulation.is_pl_defeated == true){
                            Console.Clear(); layout.border_layout();
                            anima.anima1("With such devastating defeat from the dragon. . . . . "); Thread.Sleep(1000); Console.WriteLine(); anima.anima1("You managed to escape. . . . . but you take the Golden Herron with you "); Continue(); Batte_Simulation.is_pl_defeated = false;static_story2 = false; // initiate epilogue
                        }
                        else{
                            Console.Clear(); layout.border_layout(); anima.anima1("With the dragon being defeated........"); Thread.Sleep(1000); Console.WriteLine(); anima.anima1("\n\t\tYou manage to take the Golden Herron"); static_story2 = true; static_story3 = true; Continue();
                            Dlg_reseter();
                            anima.anima1("Exiting the Enchanted Cave, you hold the Lost Herron in your hands,\n\tmemories of battles and encounters lingering.\n\tThe amulet around your neck and the rewards collected serve as reminders. \n\tDepending on your choices, you either use the Herron to bring prosperity, \n\t or misuse its power");
                            Continue();break;
                        }
                        break; 
                        case "take":
                        Console.Clear(); layout.border_layout(); anima.anima1("You safely take the Golden Herron and go on your way"); Continue();  // initiate epilogue
                        Dlg_reseter();
                        anima.anima1("\tExiting the Enchanted Cave, you hold the Lost Herron in your hands,\n\tmemories of battles and encounters lingering.\n\tThe amulet around your neck and the rewards collected serve as reminders. \n\tDepending on your choices, you either use the Herron to bring prosperity, \n\tmisuse its power, or return it to the hooded figure");
                        Continue(); Console.Clear(); layout.border_layout(); anima.anima1("EPILOGUE . . . . . . . . . . . "); Continue();break;
                    }
                break;
                
           }

        }
        public static void Dialogue_13(){ // ending
            Dlg_reseter();
            anima.anima1("\tExiting the Enchanted Cave, you hold the Lost Herron in your hands,\n\tmemories of battles and encounters lingering.\n\tThe amulet around your neck and the rewards collected serve as reminders. \n\tDepending on your choices, you either use the Herron to bring prosperity, \n\tmisuse its power, or return it to the hooded figure");
            Continue();


        }
        public static void wkfn (){

        }
        public static void Ending_2(){

        }
        public static void Dead(){
        }
        public static void Ending_and_epilogues(){

            SfX.Ending();

            // The model knight ? -- The Player Returned with the herron or Never returned as a living person -->
            if (static_story3 == true){
                Console.Clear(); layout.border_layout();
                anima.anima1("\x1b[34mThe Model Knight\x1b[0m"); Thread.Sleep(1000);anima.anima1("\n\n\tYou Returned to the Kingdom of Rohann with the Golden Herron. \n\tPeople cheer as you walk pass on the city streets. \n\tYou handed the Golden Herron the Kingdom's Sorcerers "); Continue();
                Console.Clear(); layout.border_layout(); anima.anima1("The Sorcerers are able to vanquish the Curse restoring the Kindoms prosper....."); Thread.Sleep(500);anima.anima1("\n\tYou are hailed as the model knight ......."); Continue();
            }
            else if (Player.battle_health> 0 && Batte_Simulation.deth_in_story_mid == false){
                Console.Clear(); layout.border_layout();
                anima.anima1("\x1b[34mThe Exile Ending\x1b[0m"); Thread.Sleep(1000);anima.anima1("\n\n\tYou Returned to the Kingdom of Rohann without the Golden Herron. \n\tPeople losses hope as you walk on the alley \n\tAt last, the remaining people leave "); Continue();
                Console.Clear(); layout.border_layout(); anima.anima1("The Kingdom has fallen"); Thread.Sleep(500);anima.anima1("\n\tAnd you as well leave and become an excile...."); Continue();
            
            }

            // The dragon slayer -- The Player defeats the dragon  and takes the herron -||- The player is defeated and return in the Kingdom of Rohann as a shameful individual
            if (static_story2 == true){
                Console.Clear(); layout.border_layout();
                anima.anima1("\x1b[34mThe dragon Slayer....\x1b[0m"); Thread.Sleep(1000);anima.anima1("\n\n\tRemember that dragon?........");Thread.Sleep(500);anima.anima1("With the defeat of the dragon, people starts to create tales about you......"); Continue();
                Console.Clear(); layout.border_layout(); anima.anima1("You are now known as the dragon Slayer......");  Continue();
            }
            else{}

            // The escapist -- When the player flee to a battle for more than one times
            if(Player.Flee_count >=3){
                Console.Clear(); layout.border_layout();
                anima.anima1("\x1b[34mThe Escapist?\x1b[0m"); Thread.Sleep(1000);anima.anima1("\n\n\t You escape most of your enemy throughout the story....."); Continue();
            }
            else{};

            // Like everybody's death -- When the player died in the middle of the story 
            if (Player.health <= 0){
                Console.Clear(); layout.border_layout();
                anima.anima1("\x1b[32mLike Everybody's Death.....?\x1b[0m"); Thread.Sleep(1000);anima.anima1("\n\n\t A dwarf recover your body from the recent battle......."); Continue();
                Console.Clear(); layout.border_layout(); anima.anima1("He then burry your corpse under a maple tree......."); Thread.Sleep(500);Continue();Console.Clear();layout.border_layout() ;anima.anima1("\n\tIn your gravestone, a poorly written words are engraved......."); Continue();
                Console.Clear();layout.border_layout() ;anima.anima1("\n\t\"He Lies Here..... An unfortunate adventurer.....\""); Continue();

            }
            else{}

            // Death by posion -- When the player died with posion 

            // Josh Hucherson ending () --> secret ending --> 10% Probability

            // The slayer - all of the monsters encountered were slaigned
            if (Player.Slained_enemy_count > 3){
                Console.Clear(); layout.border_layout();
                anima.anima1("\x1b[32mThe Slayer?\x1b[0m");
                anima.anima1("\n\tYou defeated more than three enemies...."); Continue();
                
            }
            else{}

            Random secret_ending_probability = new Random();
            int s_ending = secret_ending_probability.Next(1,100);


            // Josh Hucherson ending -- > meme reference
            if (s_ending < 10 || Player.Player_name.ToLower() == "josh"){
                Secret_ending_count += 1;
                Console.Clear(); layout.border_layout();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                anima.anima1("\x1b[32mThe Josh Hutcherson Ending?\x1b[0m");
                anima.anima1("\n\t*Whistle noises ..............*"); Continue();
                Console.ResetColor();
                



            }

            // Developers ending reference
            if (Player.Player_name.ToLower() == "lods" || Player.Player_name.ToLower() ==  "len" || Player.Player_name.ToLower() == "buknoy" || Player.Player_name.ToLower() == "andrei"){
                 Secret_ending_count += 1;
                 Console.Clear(); layout.border_layout();
                anima.anima1("\x1b[32mThe Devs Ending\x1b[0m");
                anima.anima1("\n\t Owww... So you used our nicknames as a player name"); Continue();
                

            }




        }

        public static void EndingStats(){

            // Status..........    
            Console.Clear(); layout.border_layout();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            layout.Box_Generator(30,2,17,60);
            Console.ResetColor();
            layout.border_layout();
            Console.SetCursorPosition(45,5);
            Console.WriteLine("Score");
            Console.WriteLine();
            Console.WriteLine($"\t\t\t\t   Story XP: ........................{story_xp}");
            Console.WriteLine($"\t\t\t\t   Battle XP ........................{battle_xp}");
            Console.WriteLine($"\t\t\t\t   Total Enemy Slained ..............{Player.Slained_enemy_count}");
            Console.WriteLine($"\t\t\t\t   Battle Losses ....................{Player.Loss_count}");
            Console.WriteLine($"\t\t\t\t   Secret Endings ...................{Secret_ending_count}/2\n\n\t\t");
            Player.Slained_enemy_count = 0;
            Player.play_count += 1; // Updates the play count of the player
            Continue();

            //Score and High score
            Console.Clear(); layout.border_layout();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            layout.Box_Generator(30,2,17,60);
            Console.ResetColor();
            Console.SetCursorPosition(45,5);
            Console.WriteLine("Score");
            Console.WriteLine();
            
            int Total_score = story_xp + battle_xp; // Current score
           
         
            if(Player.play_count > 0){
               
                if(Total_score >= Score.High_Score()){
                    //Delete the file contents
                    Score.Delete_or_update_score(@"High_Score_System\Current_highscore.txt");
                    Score.Delete_or_update_score(@"High_Score_System\Current_score.txt");
                    //Write the new ones
                    Score.Score_writer(Total_score,Total_score);

                }
                 else{
                    Score.Delete_or_update_score(@"High_Score_System\Current_score.txt");
                    Score.Score_writer(Total_score,Score.High_Score());
                }
           

            }

          


            
           

            //High Score

           


           
          
            Console.WriteLine($"\t\t\t\t   Total Score (XP): ................{story_xp + battle_xp}");
            Console.WriteLine($"\t\t\t\t  High Score .......................{Score.High_Score()}");
            Continue();
           
          
            
           


            

        }

    }
}
