
using player;
using Selection;
using System.Diagnostics.SymbolStore;
using System.Net.NetworkInformation;
using System.Threading;


/*

IMPORTANT NOTE

Use the methods: 

    Dlg_Resetter() - for resetting the consol layout
    sel_1() - this is reserved
    sel_2() - in-line selecttion -> can take 4 arguments
    sel_3() - horizontal selsction -> can take 4 arguments



*/





namespace Story{


    class story{

        public static bool static_story1 ; // Map is accepted
         public static bool static_story2 ; // Knowledge of the dwarf
          public static bool static_story3 ; 


        public static int pos_t;
        public static int pos_w; 
        public static void Dlg_reseter(){ // reset and initiate the dialogue frame
            Console.Clear();
            layout.border_layout();
            Console.SetCursorPosition(3,3);
        }
        public static void Press(){ // Ask for the user input. to continue the story even further 
            //Console.Write("\n\n\t\t\t\t\x1b[4m                                  \x1b[0m");
            Console.Write("\n\n\n\t\t\t\t\x1b[1mPress any key to continue. . . . . . . . . . . .\x1b[0m ");
            Console.ReadKey();

        }
        public static void Continue(){
            (pos_w, pos_t) = Console.GetCursorPosition();
            Console.SetCursorPosition(3,pos_t);
        }
        public static void battle_start(){
            Dlg_reseter();
            anima.anima1("Begin Battle > > > > > ");
            Console.ReadKey();
        }

        public static void Dialogue_1() // This is the welcoming dialogue
        { 
            (int wi , int h) =Console.GetCursorPosition();
            Console.Clear();
            layout.border_layout();
            anima.anima1($"On the cheers of the crowd, A hero by the name of {Player.Player_name} enters the stage" );
            
            layout.def_layout();
            Console.SetCursorPosition(3,h+1);
            anima.anima1("With all of the cheering crowd and embracing glory, you go out on your journey");
            Console.SetCursorPosition(3,h+ 2);
            anima.anima1("Bearing the promise of having glory, and returning as a hero");
            Console.ReadLine();
            Player.health = 100;
            Player.damage = 1;
            Player.armor = 1;
        }
        public static void Dialogue_2(){
            string a = $"You find yourself in the quaint village of Stellar,\n\t surrounded by towering medieval structures and cobbled streets. \n\t  The air is filled with the aroma of freshly baked bread, and distant sounds \n\t  of clashing swords echo from the training grounds. \n\t As you stroll through the marketplace, an old beggar approaches you,\n\t  handing you a weathered map";
            Dlg_reseter();
            anima.anima1(a);
            (int wi , int h) =Console.GetCursorPosition();
            Console.SetCursorPosition(40,h+3);
            (system_selection.c_with, system_selection.c_top ) = Console.GetCursorPosition();
            system_selection.sel_1();

            switch (system_selection.sel_option){
                case 1: anima.anima1("\n\n\t\tYou accept the map and go on your ways"); break;
                case 2: anima.anima1("\n\n\t\tYou Refuse the map "); break;
                case 3: anima.anima1("\n\n\t\tYou go on your ways "); break;
            }
            Press();
            Console.Clear();
            layout.border_layout();

            if (system_selection.sel_option != 1){
                anima.anima1("\n\n\t\t . Refusing the map, you find yourself with little to do in the village, \x1b[31mgrowing weary\x1b[0m. \n\tIt forces you to go back to the old beggar and accept the map.");
                Press();
            }

        }
        public static void Dialogue_3(){
            Console.Clear();
            layout.border_layout();
            anima.anima1("\t\tAccepting the map, you discover it leads to the legendary Lost Herron \n\t hidden deep within the treacherous Darkwood Forest.");
            system_selection.sel_3("Gather supplies from the village before embarking on the journey","Head straight to the Darkwood Forest without any preparation");
            Press();

            // The Battle happen

        }

        public static void Dialogue_4(){
            Console.Clear();
            layout.border_layout();
            anima.anima1("\n\n\tAs you delve into the heart of Darkwood, a forked path presents itself");
            system_selection.sel_3("Take the well-trodden path","Venture into the dense thicket");
            Press();
        }

        public static void Dialogue_5(){
            Dlg_reseter();

            switch (system_selection.sel_option){ // Need to finish the function for the battle 
                case 1: Dlg_reseter(); anima.anima1("Chossing the \x1b[33mwell-trodden Path, /t/n you encountered a mystirious hooded figure\x1b[0m ");  break;
                case 2: Dlg_reseter(); anima.anima1("Choosing the \x1b[33m Dense ticket path, you encountered a mystirous hooded figure\x1b[0m"); break;
            }

            system_selection.sel_3("Approach the figure cautiously","Avoid the figure and continue on your way");

            switch (system_selection.sel_option){
                case 1: Console.WriteLine("You approach the figure cautiously"); break;
                case 2: Console.WriteLine("Avoiding the hooded figure, \n\t\t you encountered a magic troll"); battle_start();break;
            }
            Press();

        }
        public static void Dialogue_5_5(){
             Dlg_reseter();
             anima.anima1("Approaching the figure, they reveal themselves as a dark sorcerer, offering you a power and health");
             system_selection.sel_2(" Accept","Decline");

             // Decline - initiatie battle 

             if(system_selection.sel_option == 1){

             }
             else if (system_selection.sel_option == 2){

             }

        }
        public static void Dialogue_7(){
            Dlg_reseter();
            anima.anima1("Continuing through Darkwood, you stumble upon a rickety bridge spanning a chasm.");
            system_selection.sel_2("Cross the bridge carefull", "Look for an alternative route"); // -> Wrong decision will let the player to encounter am ogre
            Press();

        }
        public static void Dialogue_8(){
            Dlg_reseter();
            anima.anima1("Crossing the bridge, you see a group of bandits holding hostage a dwarf.");
            system_selection.sel_2("Save the dwarf", "Don't save the dwarf");

        }
        public static void Dialogue_10(){
            Dlg_reseter();
            anima.anima1("After that encounter, you reach the Enchanted Cave where the Herron is rumored to rest.");
            system_selection.sel_2("Scout the surroundings before entering", "Enter the cave boldly");
            Press();

        }
        public static void Dialogue_11(){
            Dlg_reseter();
            anima.anima1("Inside the cave, you face a choice between two tunnels");
            system_selection.sel_2("Choose the left tunnel","Choose the right tunnel."); // Must have a randomizer
            Press();

        }
        public static void Dialogue_12(){
            Dlg_reseter();
            anima.anima1("After navigating the tunnels, you find yourself in the presence of the Lost Herron");
            system_selection.sel_2("Inspect the surroundings for any traps before taking the Herron","Reach out and take the Herron");
            Press();

        }
        public static void Dialogue_13(){ // ending
            Dlg_reseter();
            anima.anima1("Exiting the Enchanted Cave, you hold the Lost Herron in your hands,\n\t memories of battles and encounters lingering. The amulet around your neck and the rewards collected serve as reminders. \n\tDepending on your choices, you either use the Herron to bring prosperity, \n\tmisuse its power, or return it to the hooded figure");
            Press();


        }
        public static void Ending_1(){

        }
        public static void Ending_2(){

        }
        public static void Ending_3(){

        }

    }
}
