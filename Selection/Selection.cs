using System.Diagnostics;
using Sound;


namespace Selection{
    class system_selection{


    public static int sel_option = 1; // Global option for dialogues
    public static int c_top;
    public static int c_with;
        public static void sel_1(){ layout.border_layout();
            var decorator  = ">> # \u001b[32m";
            bool select = true;
           
            while(select != false){
                //Console.Write(new string(' ', Console.BufferWidth - Console.CursorLeft)); // Reset the Option display
                Console.SetCursorPosition(20,c_top + 3);
                
                
                Console.Write($"\t{(sel_option == 1 ? decorator : "   ")} Accept \u001b[0m");
                Console.Write($"  {(sel_option == 2 ? decorator : "   ")} Refuse \u001b[0m");
                Console.Write($"  {(sel_option == 3 ? decorator : "   ")} Inventory \u001b[0m");
                Console.Write($"  {(sel_option == 4 ? decorator : "   ")} Ignore \u001b[0m");
                
                ConsoleKeyInfo key = Console.ReadKey();

            SfX.Selection1();
                



                switch (key.Key){

                    case ConsoleKey.LeftArrow:
                    sel_option = sel_option == 1 ? 4 : sel_option -1; 
                    break;

                    case ConsoleKey.RightArrow:
                    sel_option = sel_option == 4 ? 1: sel_option + 1;
                    break;

                    case ConsoleKey.Enter:
                    select = false;
                    break;
            }

            }



        }
    }
}