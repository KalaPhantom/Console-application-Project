
using System.Runtime.CompilerServices;
using enemy;
using player;
using Selection;
using Simulations;


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
 
        public static bool static_story1 ; // Map is accepted -
         public static bool static_story2 ; // Knowledge of the dwarf - Moderate
        public static bool static_story3 ; // Good ending
        public static bool static_story5; // Gathered supplies - Crucial

        // 

        public static bool epilogue_1; // The Escapist's ending --> all of the monsters he encountered
        public static bool epilogue_2; // The dragon slayer
        public static bool epilogue_3; // The model knight
        public static bool epilogie_4; // The slayer - all of the monsters encountered were slaigned

        


        public static int pos_t;
        public static int pos_w; 
        public static void Dlg_reseter(){ // reset and initiate the dialogue frame
            Console.Clear();
            layout.border_layout();
            Console.SetCursorPosition(3,3);
        }
        public static void Health_reset(){
            Player.battle_health = 50;
        }
        public static void Press(){ // Ask for the user input. to continue the story even further 
            
            anima.anima1("\n\t\t\t\t\tx1b[1mPress any key to continue. . . . . . . . . . . .\x1b[0m ");
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
            anima.anima1("People..."); Thread.Sleep(500); anima.anima1("They died of diseases"); Thread.Sleep(500); anima.anima1("\n\tFarmlands were not able to produce crops, Trees and plants starts to wither and some other people\n\t already left the kingdom");
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
        public static void Dialogue_2(){
            string a = $"\tYou find yourself in the quaint village of Stellar,\n\tsurrounded by towering medieval structures and cobbled streets. \n\tThe air is filled with the aroma of freshly baked bread, and distant sounds \n\tof clashing swords echo from the training grounds. \n\tAs you stroll through the marketplace, an old beggar approaches you,\n\thanding you a weathered map";
            Dlg_reseter();
            anima.anima1(a);
            (int wi , int h) =Console.GetCursorPosition();
            Console.SetCursorPosition(40,h+3);
            (system_selection.c_with, system_selection.c_top ) = Console.GetCursorPosition();
            system_selection.sel_1();

            switch (system_selection.sel_option){
                case 1: Console.Clear(); layout.border_layout(); anima.anima1("\n\n\t\t\tYou accept the map and go on your ways"); break;
                case 2: Console.Clear(); layout.border_layout();anima.anima1("\n\n\t\t\t\tYou Refuse the map "); break;
                case 3: Console.Clear(); layout.border_layout();anima.anima1("\n\n\t\t\t\tYou go on your ways "); break;
            }
            Console.WriteLine("");
            Press();
            Console.Clear();
            layout.border_layout();

            if (system_selection.sel_option != 1){
                anima.anima1("\n\n\n\t\t . Refusing the map, you find yourself with little to do in the village, \x1b[31mgrowing weary\x1b[0m. \n\tIt forces you to go back to the old beggar and accept the map.");
                Press();
            }

        }
        public static void Dialogue_3(){
            Random rnd_situation = new Random();
            int a = rnd_situation.Next(1,100);


            Console.Clear();
            layout.border_layout();
            anima.anima1("\t\tAccepting the map, you discover it leads to the legendary Lost Herron \n\thidden deep within the treacherous Darkwood Forest.");
            system_selection.sel_3("Gather supplies from the village before embarking on the journey","Head straight to the Darkwood Forest without any preparation");
            switch(system_selection.sel_option){
                case 1: Console.WriteLine("\n\n\t\tYou gathered the necessary supplies and go on your ways");break;
                case 2: 
                    switch(a > 50? "Success" : "Fail"){
                        case "Success":  break; // Will not affect the ending
                        case "Fail": break; // Will lessens the players Health and affects the ending

                    }
                    Console.Clear(); layout.border_layout();
                    anima.anima1("\n\n\t\t\tWith Confidence - You decide to go ");break;
            }
            Continue();
            // The Battle happen
        }

        public static void Dialogue_4(){
            Console.Clear();
            layout.border_layout();
            anima.anima1("\n\n\tAs you delve into the heart of Darkwood, a forked path presents itself");
            system_selection.sel_3("Take the well-trodden path","Venture into the dense thicket");

            Random rnd = new Random();
            int chances_random = rnd.Next(1,100);


            if (system_selection.sel_option == 1){
                switch (chances_random < 90? "avoid": chances_random > 90? "battle": "avoid"){
                    case "avoid":Console.Clear(); layout.border_layout(); anima.anima1("\n\t\t\tyou passed safely"); break;
                    case "battle":Console.Clear(); layout.border_layout();anima.anima1("\n\t\t\tYou enecoutered a wolf"); Continue();  battle_start(); Batte_Simulation.battle1(Enemy_Health.Wolf_Health,Enemy_Health.Wolf_Damage,Enemy_Health.Wolf_dodge_rate, Enemy_Health.Wolf_attack_rate,Enemy_Health.Wolf_miss_chances,"Wolf");
                    break;
                }
            }
            else if (system_selection.sel_option == 2){
                switch (chances_random < 90? "battle": chances_random > 90? "avoid": "battle"){
                    case "avoid": anima.anima1("you passed safely"); break;
                    case "battle": anima.anima1("\n\t\t\tYou enecoutered a wolf"); battle_start(); Batte_Simulation.battle1(Enemy_Health.Wolf_Health,Enemy_Health.Wolf_Damage,Enemy_Health.Wolf_dodge_rate, Enemy_Health.Wolf_attack_rate,Enemy_Health.Wolf_miss_chances,"Wolf");
                    break;
                }

            }
            // Battle happens // fight with a wolf
            Player.battle_health = 50; // Reset

            Continue();
        }

        public static void Dialogue_5(){
            Dlg_reseter();

            switch (system_selection.sel_option){ // Need to finish the function for the battle 
                case 1: Dlg_reseter(); anima.anima1("Chossing the \x1b[33mwell-trodden Path, you encountered a mystirious hooded figure\x1b[0m \n\n\t You have no Idea if it is Hostile ");  break;
                case 2: Dlg_reseter(); anima.anima1("Choosing the \x1b[33m Dense ticket path, you encountered a mystirous hooded figure\x1b[0m \n\n\t You have no idea if it is Hostile"); break;
            }

            system_selection.sel_3("Approach the figure cautiously","Avoid the figure and continue on your way");
            system_selection.sel_option = 1;
            switch (system_selection.sel_option){
                case 1: anima.anima1("\n\n\t\tYou approach the figure cautiously"); break; //  friendly _ Easy // Normal - Random
                case 2: anima.anima1("\n\n\t\tAvoiding the hooded figure, \n\t\t you encountered a magic troll"); battle_start();Batte_Simulation.battle1(Enemy_Health.Troll_Health,Enemy_Health.Troll_Dmg,Enemy_Health.Troll_dodge_rate,Enemy_Health.Troll_attack_rate, Enemy_Health.Troll_miss_chances, "Magic Troll");
            break;
            }
            Press();

        }
        public static void Dialogue_5_5(){
             Dlg_reseter();
             system_selection.sel_option = 1;
             
             if (Batte_Simulation.is_pl_defeated == true){
                anima.anima1("Recovering from the battle, the mysterious hooded figure from the distance vanished");
                Batte_Simulation.is_pl_defeated = true;
             }
             else{
                  anima.anima1("Approaching the figure, they reveal themselves as a dark sorcerer, offering you a power and health");
                  system_selection.sel_2(" Accept","Decline"); 
             }
           
             if(system_selection.sel_option == 1){ // depends on the difficulty
                Player.damage += 20;

             }
             else if (system_selection.sel_option == 2){
                Batte_Simulation.battle1(Enemy_Health.Dark_sorcerer_health, Enemy_Health.Dark_sorcerer_dmg, Enemy_Health.Dark_sorcerer_dodge_rate,Enemy_Health.Dark_sorcerer_attack_rate,Enemy_Health.Dark_sorcerer_miss_chances, "Dark Sorcerer");
             }

        }
        public static void Dialogue_7(){
            system_selection.sel_option = 1;
            Dlg_reseter();
            anima.anima1("Continuing through Darkwood, you stumble upon a rickety bridge spanning a chasm.");
            system_selection.sel_2("Cross the bridge carefull", "Look for an alternative route"); // -> Wrong decision will let the player to encounter am ogre // or a bridge will collapse

            Random random_situation = new Random();
            switch (system_selection.sel_option){
                case 1:// -------
                Console.WriteLine("\n\n\t\t You carefully thread the bridge"); 
                int situation1 = random_situation.Next(1,100);

                switch (situation1 > 50? "battle" : situation1 <= 20? "collapse" :"safe" ){
                    case "safe": //The bridge stay intacted
                    case "battle": Batte_Simulation.battle1(Enemy_Health.Ogre_Health,Enemy_Health.Ogre_dmg,Enemy_Health.Ogre_dodge_rate,Enemy_Health.Ogre_attack_rate,Enemy_Health.Ogre_miss_chances,"Ogre"); break; // You encountered an ogre
                    case "collapse": Player.health -= 1 ; Console.WriteLine($"\n\n\t\t The Bridge Collapsed, but you manage to get up and continue on your ways \n\n\t\t\t You have {Player.health} health chances left"); break;// The bridge collapse
                    }
                break;

                case 2: // -----
                Console.WriteLine("\n\n\t\t You look for the alternative route"); 
                Random random_situation2 = new Random();
                int situation2 = random_situation2.Next(1,100);

                switch (situation2 > 70? "Safe" : "battle"){
                    case "Safe": Console.WriteLine("\n\n\t\tYou successfully find an alternative route"); break;
                    case "battle":
                    Console.Clear();
                    layout.border_layout();
                    anima.anima1("\n\n\t\t \x1b[31mYou encoutered an Ogre . . . . . . . \x1b[0m");
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
                
                if (Batte_Simulation.is_pl_defeated == false){
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
                        anima.anima1("\n\n\t\t\"Beware of the dragon . . . . . . . ."); Continue();

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
                        anima.anima1("\n\n\t\t \"Slain that dragon adventurer........\" The dwarf mutered at a distance \n\t\tYou have no clue what on what he just said"); Continue();

                    }
                }
                else {Batte_Simulation.is_pl_defeated = false;}

            }
            else{
                anima.anima1("You escape the scene ............");
            }
           
        }

        public static void Dialogue_10(){ // Death by poision -- epilogue
            Dlg_reseter();
            anima.anima1("After that encounter, you reach the Enchanted Cave where the Herron is rumored to rest.");
            system_selection.sel_2("Scout the surroundings before entering", "Enter the cave boldly"); // Wrong choice will lead for the bubby trap with poison lessening the health of the player by 2
            
            switch (system_selection.sel_option){
                case 1: Console.Clear(); layout.border_layout(); anima.anima1("\n\n\t\tYou scouted the area and found a trap . . . . . "); anima.anima1("\n\n\t\t You manage to thread carefully");break;
                case 2: Console.Clear(); layout.border_layout();
                anima.anima1("\n\n\t\tWith overwhelming confidence, you decided to eneter to the cave boldy         "); Continue(); Console.Clear(); layout.border_layout();
                anima.anima1("\n\n\t\t CLAANGGG!!!!, A spike trap impaled your feet inflicting poison to your body"); // We can give the player a choice tyo give up - if the player given up - it will give us an immidiete ending  - either the player died of poison, or the player manage to arrive in the nearby town for a posion cure 
                // Poison attribute goes here s
                break;

            }

            Press();

        }
        public static void Dialogue_11(){
            Dlg_reseter();
            anima.anima1("Inside the cave, you face a choice between two tunnels");
            system_selection.sel_2("Choose the left tunnel","Choose the right tunnel."); // Must have a randomizer
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

            case 1://////////////////////////////////
                Console.Clear(); layout.border_layout();

                switch(dragon_appearance > 20? "battle" : "sleep"){
                    case "battle": 
                     anima.anima1("As you are inspecting the sorroundings....."); Thread.Sleep(1000);anima.anima1("A dragon emerges from the darkness..."); Continue(); Console.Clear(); layout.border_layout(); battle_start();
                        Console.Clear(); layout.border_layout(); Batte_Simulation.battle1(Enemy_Health.Dragon_health,Enemy_Health.Dragon_dm, Enemy_Health.Dragon_dodge_rate,Enemy_Health.Dragon_attack_rate,Enemy_Health.Dragon_miss_chances,"Dragon");
                        if(Batte_Simulation.is_pl_defeated == true && Player.health <0){
                            Console.Clear(); layout.border_layout();
                            anima.anima1("With such devastating defeat from the dragon. . . . . "); Thread.Sleep(1000); Console.WriteLine(); anima.anima1("You managed to escape. . . . . "); Continue(); Batte_Simulation.is_pl_defeated = false; // initiate epilogue
                        }
                        else{
                            Console.Clear(); layout.border_layout(); anima.anima1("With the dragon being defeated........"); Thread.Sleep(1000); Console.WriteLine(); anima.anima1("You manage to take the Golden Herron"); Continue();
                            Dlg_reseter();
                            anima.anima1("Exiting the Enchanted Cave, you hold the Lost Herron in your hands,\n\tmemories of battles and encounters lingering.\n\tThe amulet around your neck and the rewards collected serve as reminders. \n\tDepending on your choices, you either use the Herron to bring prosperity, \n\tmisuse its power, or return it to the hooded figure");
                            Continue();break;
                        }
                    break;


                    case "sleep": 
                        Console.Clear(); layout.border_layout(); anima.anima1(" You found a sleeping dragon as you inspect your sorroundings....... \n\tYou safely take the Golden Herron and go on your way"); Continue();  // initiate epilogue
                        Dlg_reseter();
                        anima.anima1("Exiting the Enchanted Cave, you hold the Lost Herron in your hands,\n\tmemories of battles and encounters lingering.\n\tThe amulet around your neck and the rewards collected serve as reminders. \n\tDepending on your choices, you either use the Herron to bring prosperity, \n\tmisuse its power, or return it to the hooded figure");
                        Continue();break;
                    
                }
            break;


            case 2: //////////////////////////////
                    switch(dragon_appearance > 10? "battle" : "take"){
                        case "battle" :
                        anima.anima1("As you are taking the Golden Herron......."); Thread.Sleep(1000);anima.anima1("A dragon emerges from the darkness..."); Continue(); Console.Clear(); layout.border_layout(); battle_start();
                        Console.Clear(); layout.border_layout(); Batte_Simulation.battle1(Enemy_Health.Dragon_health,Enemy_Health.Dragon_dm, Enemy_Health.Dragon_dodge_rate,Enemy_Health.Dragon_attack_rate,Enemy_Health.Dragon_miss_chances,"Dragon");
                        if(Batte_Simulation.is_pl_defeated == true && Player.health <0){
                            Console.Clear(); layout.border_layout();
                            anima.anima1("With such devastating defeat from the dragon. . . . . "); Thread.Sleep(1000); Console.WriteLine(); anima.anima1("You managed to escape. . . . . "); Continue(); Batte_Simulation.is_pl_defeated = false; // initiate epilogue
                        }
                        else{
                            Console.Clear(); layout.border_layout(); anima.anima1("With the dragon being defeated........"); Thread.Sleep(1000); Console.WriteLine(); anima.anima1("You manage to take the Golden Herron"); Continue();
                            Dlg_reseter();
                            anima.anima1("Exiting the Enchanted Cave, you hold the Lost Herron in your hands,\n\tmemories of battles and encounters lingering.\n\tThe amulet around your neck and the rewards collected serve as reminders. \n\tDepending on your choices, you either use the Herron to bring prosperity, \n\tmisuse its power, or return it to the hooded figure");
                            Continue();break;
                        }
                        break; 
                        case "take":
                        Console.Clear(); layout.border_layout(); anima.anima1("You safely take the Golden Herron and go on your way"); Continue();  // initiate epilogue
                        Dlg_reseter();
                        anima.anima1("Exiting the Enchanted Cave, you hold the Lost Herron in your hands,\n\tmemories of battles and encounters lingering.\n\tThe amulet around your neck and the rewards collected serve as reminders. \n\tDepending on your choices, you either use the Herron to bring prosperity, \n\tmisuse its power, or return it to the hooded figure");
                        Continue();break;
                    }
                break;
                



           }

        }
        public static void Dialogue_13(){ // ending
            Dlg_reseter();
            anima.anima1("Exiting the Enchanted Cave, you hold the Lost Herron in your hands,\n\tmemories of battles and encounters lingering.\n\tThe amulet around your neck and the rewards collected serve as reminders. \n\tDepending on your choices, you either use the Herron to bring prosperity, \n\tmisuse its power, or return it to the hooded figure");
            Continue();


        }
        public static void Ending_1(){

        }
        public static void Ending_2(){

        }
        public static void Dead(){
        }
        public static void Ending_and_epilogues(){

        }

    }
}
