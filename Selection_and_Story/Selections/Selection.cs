
using Sound;


namespace Selection{
    class system_selection{


    public static int sel_option = 1; // Global option for dialogues
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
        public static void sel_2_battle(string a, string b, string c){ layout.Battle_layout();    // ---> Used for the first selection
            var decorator  = ">> # \u001b[32m";
            bool select = true;
           
            while(select != false){
                //Console.Write(new string(' ', Console.BufferWidth - Console.CursorLeft)); // Reset the Option display
                Console.SetCursorPosition(35,22); // static permanent position 
                
                
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
                    layout.def_layout();
            }
        }
         public static void sel_3(string a, string b, string c){ layout.border_layout();    // ---> Used for the first selection
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






    }
}