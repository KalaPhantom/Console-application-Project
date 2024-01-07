
using Sound;
using Simulations;


namespace Selection{
    class system_selection{


    public static int sel_option = 1; // Global option for dialogues

    public static int battle_sel_option = 1;
    public static int c_top;
    public static int c_with;
        public static void sel_1(){ layout.border_layout();    // ---> Used for the first selection
            var decorator  = ">> # \u001b[32m";
            bool select = true;
           
            while(select != false){
                //Console.Write(new string(' ', Console.BufferWidth - Console.CursorLeft)); // Reset the Option display
                Console.SetCursorPosition(20,c_top + 3);
                
                
                Console.Write($"\t{(sel_option == 1 ? decorator : "   ")} Accept \u001b[0m");
                Console.Write($"  {(sel_option == 2 ? decorator : "   ")} Refuse \u001b[0m");
                Console.Write($"  {(sel_option == 3 ? decorator : "   ")} Ignore \u001b[0m");
                //Console.Write($"  {(sel_option == 4 ? decorator : "   ")} Ignore \u001b[0m");
                
                ConsoleKeyInfo key = Console.ReadKey();

                 SfX.Selection1(); // Caleed method for the Sound effects
                
                    switch (key.Key){

                        case ConsoleKey.LeftArrow:
                        sel_option = sel_option == 1 ? 3 : sel_option -1; 
                        break;

                        case ConsoleKey.RightArrow:
                        sel_option = sel_option == 3 ? 1: sel_option + 1;
                        break;

                        case ConsoleKey.Enter:
                        select = false;
                        break;
                    }

            }



        }
         public static void sel_2(string a, string b, string c){ layout.border_layout();    // ---> Used for the first selection
            var decorator  = ">> # \u001b[32m";
            bool select = true;
           
            while(select != false){
                //Console.Write(new string(' ', Console.BufferWidth - Console.CursorLeft)); // Reset the Option display
                Console.SetCursorPosition(20,c_top + 3);
                
                
                Console.Write($"\t{(sel_option == 1 ? decorator : "   ")} {a} \u001b[0m");
                Console.Write($"  {(sel_option == 2 ? decorator : "   ")} {b} \u001b[0m");
                Console.Write($"  {(sel_option == 3 ? decorator : "   ")} {c} \u001b[0m");
                //Console.Write($"  {(sel_option == 4 ? decorator : "   ")} Ignore \u001b[0m");
                
                ConsoleKeyInfo key = Console.ReadKey();

                 SfX.Selection1(); // Caleed method for the Sound effects
                
                    switch (key.Key){

                        case ConsoleKey.LeftArrow:
                        sel_option = sel_option == 1 ? 4 : sel_option -1; 
                        break;

                        case ConsoleKey.RightArrow:
                        sel_option = sel_option == 3 ? 1: sel_option + 1;
                        break;

                        case ConsoleKey.Enter:
                        select = false;
                        break;
                    }
            }
        }

         public static void sel_2(string a, string b){ layout.border_layout();    // ---> Used for the first selection
            var decorator  = ">> # \u001b[32m";
            bool select = true;
           
            while(select != false){
                //Console.Write(new string(' ', Console.BufferWidth - Console.CursorLeft)); // Reset the Option display
                Console.SetCursorPosition(20,c_top + 3);
                
                
                Console.Write($"\t{(sel_option == 1 ? decorator : "   ")} {a} \u001b[0m");
                Console.Write($"  {(sel_option == 2 ? decorator : "   ")} {b} \u001b[0m");
                //Console.Write($"  {(sel_option == 3 ? decorator : "   ")} {c} \u001b[0m");
                //Console.Write($"  {(sel_option == 4 ? decorator : "   ")} Ignore \u001b[0m");
                
                ConsoleKeyInfo key = Console.ReadKey();

                 SfX.Selection1(); // Caleed method for the Sound effects
                
                    switch (key.Key){

                        case ConsoleKey.RightArrow:
                        sel_option = sel_option == 1 ? 2 : sel_option -1; 
                        break;

                        case ConsoleKey.LeftArrow:
                        sel_option = sel_option == 2 ? 1: sel_option + 1;
                        break;

                        case ConsoleKey.Enter:
                        select = false;
                        break;
                    }
            }
        }
        public static void sel_menu(string a, string b){     // ---> Used for the first selection
            var decorator  = ">> # \u001b[32m";
            bool select = true;
           
            while(select != false){
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                layout.Box_Generator(40,10,8,40);
                Console.ResetColor();
                //Console.Write(new string(' ', Console.BufferWidth - Console.CursorLeft)); // Reset the Option display
                Console.SetCursorPosition(46,13);
                
                
                Console.Write($"\t{(sel_option == 1 ? decorator : "   ")} {a} \u001b[0m");
                Console.Write($"  {(sel_option == 2 ? decorator : "   ")} {b} \u001b[0m");
                //Console.Write($"  {(sel_option == 3 ? decorator : "   ")} {c} \u001b[0m");
                //Console.Write($"  {(sel_option == 4 ? decorator : "   ")} Ignore \u001b[0m");
                
                ConsoleKeyInfo key = Console.ReadKey();
               
               
                 SfX.Selection1(); // Caleed method for the Sound effects
                
                    switch (key.Key){

                        case ConsoleKey.RightArrow:
                        sel_option = sel_option == 1 ? 2 : sel_option -1; 
                        break;

                        case ConsoleKey.LeftArrow:
                        sel_option = sel_option == 2 ? 1: sel_option + 1;
                        break;

                        case ConsoleKey.Enter:
                        select = false;
                        break;
                    }
            }
        }
        public static void sel_2_battle(string a, string b, string c){ layout.Battle_layout();    // ---> Used for the first selection
            var decorator  = ">> # \u001b[32m";
            bool select = true;
           
            while(select != false){
                //Console.Write(new string(' ', Console.BufferWidth - Console.CursorLeft)); // Reset the Option display
                Console.SetCursorPosition(35,22); // static permanent position 
                
                
                Console.Write($"\t{(battle_sel_option == 1 ? decorator : "   ")} {a} \u001b[0m");
                Console.Write($"  {(battle_sel_option == 2 ? decorator : "   ")} {b} \u001b[0m");
                Console.Write($"  {(battle_sel_option == 3 ? decorator : "   ")} {c} \u001b[0m");
                //Console.Write($"  {(sel_option == 4 ? decorator : "   ")} Ignore \u001b[0m");

                
                switch(battle_sel_option){
                    case 1: Batte_Simulation.action_box_resetter(); Batte_Simulation.action_box_pos(); Console.Write("Attack the enemy"); break;
                    case 2: Batte_Simulation.action_box_resetter(); Batte_Simulation.action_box_pos(); Console.Write("dodge the enemy attack"); break;
                    case 3: Batte_Simulation.action_box_resetter(); Batte_Simulation.action_box_pos(); Console.Write("Flee (10% success rate)"); break;
                }

                
                ConsoleKeyInfo key = Console.ReadKey();

                 SfX.Selection1(); // Caleed method for the Sound effects
                
                    switch (key.Key){

                        case ConsoleKey.LeftArrow:
                        battle_sel_option = battle_sel_option == 1 ? 4 : battle_sel_option -1; 
                        break;

                        case ConsoleKey.RightArrow:
                        battle_sel_option = battle_sel_option == 3 ? 1: battle_sel_option + 1;
                        break;

                        case ConsoleKey.Enter:
                        select = false;
                        break;
                    }
                    layout.def_layout();
            }
        }
         public static void sel_3(string a, string b, string c){ // ---> Used for the first selection
            layout.border_layout();    
            var decorator  = ">>#\u001b[32m";
            bool select = true;
           
            while(select != false){
                //Console.Write(new string(' ', Console.BufferWidth - Console.CursorLeft)); // Reset the Option display
                Console.SetCursorPosition(0,c_top + 3);
                
                
                Console.WriteLine($"\t{(sel_option == 1 ? decorator : "   ")}{a}\u001b[0m");
                Console.WriteLine($"\t{(sel_option == 2 ? decorator : "   ")}{b}\u001b[0m");
                Console.WriteLine($"\t{(sel_option == 3 ? decorator : "   ")}{c}\u001b[0m");
                //Console.Write($"  {(sel_option == 4 ? decorator : "   ")} Ignore \u001b[0m");
                
                ConsoleKeyInfo key = Console.ReadKey();

                 SfX.Selection1(); // Caleed method for the Sound effects
                
                    switch (key.Key){

                        case ConsoleKey.UpArrow:
                        sel_option = sel_option == 1 ? 3 : sel_option -1; 
                        break;

                        case ConsoleKey.DownArrow:
                        sel_option = sel_option == 3 ? 1: sel_option + 1;
                        break;

                        case ConsoleKey.Enter:
                        select = false;
                        break;
                    }
            }
        }
         public static void sel_3(string a, string b){ layout.border_layout();    // ---> Used for the first selection
            var decorator  = ">>#\u001b[32m";
            bool select = true;
           
            while(select != false){
                //Console.Write(new string(' ', Console.BufferWidth - Console.CursorLeft)); // Reset the Option display
                Console.SetCursorPosition(0,c_top + 3); 
                
                
                Console.WriteLine($"\t\t{(sel_option == 1 ? decorator : "   ")}{a}\u001b[0m");
                Console.WriteLine($"\t\t{(sel_option == 2 ? decorator : "   ")}{b}\u001b[0m");
                //Console.WriteLine($"  {(sel_option == 3 ? decorator : "   ")} {c} \u001b[0m");
                //Console.Write($"  {(sel_option == 4 ? decorator : "   ")} Ignore \u001b[0m");
                
                ConsoleKeyInfo key = Console.ReadKey();

                 SfX.Selection1(); // Called method for the Sound effects
                
                    switch (key.Key){

                        case ConsoleKey.UpArrow:
                        sel_option = sel_option == 1 ? 2 : sel_option -1; 
                        break;

                        case ConsoleKey.DownArrow:
                        sel_option = sel_option == 2 ? 1: sel_option + 1;
                        break;

                        case ConsoleKey.Enter:
                        select = false;
                        break;
                    }
            }
        }
        public static void sel_3_diff(string a, string b, string c){ layout.border_layout_1();    // ---> Used for the first selection
            var decorator  = ">>#\u001b[32m";
            bool select = true;
           
            while(select != false){
                //Console.Write(new string(' ', Console.BufferWidth - Console.CursorLeft)); // Reset the Option display
            
                Console.SetCursorPosition(5,10);
                
                Console.WriteLine($"\t{(sel_option == 1 ? decorator : "   ")}{a}\u001b[0m");
                Console.WriteLine($"\t{(sel_option == 2 ? decorator : "   ")}{b}\u001b[0m");
                Console.WriteLine($"\t{(sel_option == 3 ? decorator : "   ")}{c}\u001b[0m");

                // Resposnisve sword position
                int pos_x = 34; int pos_y = 7;
                 
                switch(sel_option){
                    case 1:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.SetCursorPosition(pos_x,pos_y);
                    Console.Write("                  _");
                    Console.SetCursorPosition(pos_x,pos_y+1);
                    Console.Write("       _         | |");
                    Console.SetCursorPosition(pos_x,pos_y+2);
                    Console.Write("      | | _______| |---------------------------------------------\\");
                    Console.SetCursorPosition(pos_x,pos_y+3);
                    Console.Write("      |:-)_______|==[]============================================>");
                    Console.SetCursorPosition(pos_x,pos_y+4);
                    Console.Write("      |_|        | |---------------------------------------------/");
                    Console.SetCursorPosition(pos_x,pos_y+5);
                    Console.Write("                 |_|");
                    Console.ResetColor();
                   
      
                      break;
     

                   
                    case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(pos_x,pos_y);
                    Console.Write("                  _");
                    Console.SetCursorPosition(pos_x,pos_y+1);
                    Console.Write("       _         | |");
                    Console.SetCursorPosition(pos_x,pos_y+2);
                    Console.Write("      | | _______| |---------------------------------------------\\");
                    Console.SetCursorPosition(pos_x,pos_y+3);
                    Console.Write("      |:-)_______|==[]============================================>");
                    Console.SetCursorPosition(pos_x,pos_y+4);
                    Console.Write("      |_|        | |---------------------------------------------/");
                    Console.SetCursorPosition(pos_x,pos_y+5);
                    Console.Write("                 |_|");
                    Console.ResetColor();
                    break;

                    case 3: 
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(pos_x,pos_y);
                    Console.Write("                  _");
                    Console.SetCursorPosition(pos_x,pos_y+1);
                    Console.Write("       _         | |");
                    Console.SetCursorPosition(pos_x,pos_y+2);
                    Console.Write("      | | _______| |---------------------------------------------\\");
                    Console.SetCursorPosition(pos_x,pos_y+3);
                    Console.Write("      |:-)_______|==[]============================================>");
                    Console.SetCursorPosition(pos_x,pos_y+4);
                    Console.Write("      |_|        | |---------------------------------------------/");
                    Console.SetCursorPosition(pos_x,pos_y+5);
                    Console.Write("                 |_|");
                    Console.ResetColor();
                    break;
                    

                }
               
                // Indicators

                string d_1 = "\x1b[36mThe Enemies has lower stats and higher attack miss chances           \x1b[0m";
                string d_2 = "\x1b[33mThe Enemies has a normal stats and attack rate\x1b[0m            ";
                string d_3 = "             \x1b[31mSo You've chosen death??\x1b[0m                        ";
               

                Console.SetCursorPosition(50,20);
                Console.Write($"{(sel_option == 1 ?$"{d_1}"  : "")}");
                Console.SetCursorPosition(50,20);
                Console.Write($"{(sel_option == 2 ?$"{d_2}"  : "")}");
                Console.SetCursorPosition(50,20);
                Console.Write($"{(sel_option == 3 ?$"{d_3}"  : "")}");
               
               
                
                ConsoleKeyInfo key = Console.ReadKey();

                 SfX.Selection1(); // Called method for the Sound effects
                
                    switch (key.Key){

                        case ConsoleKey.UpArrow:
                        sel_option = sel_option == 1 ? 3 : sel_option -1; 
                        break;

                        case ConsoleKey.DownArrow:
                        sel_option = sel_option == 3 ? 1: sel_option + 1;
                        break;

                        case ConsoleKey.Enter:
                        select = false;
                        break;
                    }
            }
        }

        






    }
}