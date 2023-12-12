
using player;
using Selection;

namespace Story{
    class story{

        public static int pos_t;
        public static int pos_w; 
        public static void Dlg_reseter(){ // reset and initiate the dialogue frame
            Console.Clear();
            layout.border_layout();
            Console.SetCursorPosition(3,3);
        }
        public static void Continue(){
            (pos_w, pos_t) = Console.GetCursorPosition();
            Console.SetCursorPosition(3,pos_t);
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

            
            
        }
    }
}
