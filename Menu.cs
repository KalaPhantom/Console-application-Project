

using Details;
using player; // Global object for the player data
using Sound;
using tesst_1;

namespace Testtt_1
{
    class menu{
        public static int dificulty = 0; // gets the difficulty
        public static int option = 1; // global difficulty option
        public static void mainmenu1(){
        
                Console.Clear();
                Console.CursorVisible = false;
                Console.ForegroundColor = ConsoleColor.Cyan; // Change the text color
                Console.WriteLine("Welcome to the Lost Herron");
                Console.ResetColor(); // resets the color of the text
                Console.WriteLine("\nUse UpArrow-key  and Down Arrowkey to navigate and press \u001b[32mEnter\u001b[0m to select:");
                (int left, int top) = Console.GetCursorPosition(); // Gets the current position of the cursor and assign it to the variable "left" and "top"
                
                var decorator = ">> \u001b[32m";
                ConsoleKeyInfo key;
                bool isSelected = false;




                while (!isSelected)
                {
                    Console.SetCursorPosition(left, top);

                    // This portion of code uses a ternary operation to highlight and select a text
                    Console.WriteLine($"\n\t{(option == 1 ? decorator : "   ")}Easy\u001b[0m");
                    Console.WriteLine($"\t{(option == 2 ? decorator : "   ")}Normal\u001b[0m");
                    Console.WriteLine($"\t{(option == 3 ? decorator : "   ")}Despair\u001b[0m");
                    Console.WriteLine($"\t{(option == 4 ? decorator : "   ")}About\u001b[0m");

                    SfX.Selection1();

                    key = Console.ReadKey(true); // -> Declared accept a key in the switch 


                    switch (key.Key) // -> Accepts a specific key from the "ConsoleKeyInfo key;"
                    {
                        case ConsoleKey.UpArrow:  // -> Onlyy reads the UpArrow key in Keyboard and modifies the value of the variable "option"
                            option = option == 1 ? 4 : option - 1;
                            break;

                        case ConsoleKey.DownArrow: // -> Only reads the Down Arrow key in the keyboard and modifies the value of the variable "option"
                            option = option == 4 ? 1 : option + 1;
                            break;

                        case ConsoleKey.Enter: // -> only reads the "Enter Key " and modifies the boolean value of "isSelected" to true, stopping the while loop from executing
                            isSelected = true;
                            break;
                    }
                }
                 Console.WriteLine($"\n{decorator}You selected Option {option} \n Press any key to continue - - - - - ");

                 Console.ReadKey(true);

                 dificulty = option;

                 switch (option){
                    case 1:  break;
                    case 2: dificulty = dificulty * 2; break;
                    case 3:  dificulty = dificulty * 30;break; 
                    case 4:  About.About_Screen(); break;

                 }

                 

        } 


        public static void acc_creation(){
            Console.WriteLine(" ");
            Console.Clear();
            layout.border_layout();
            Player player = new Player();


            Console.Title = "Create your player";
            Console.ForegroundColor= ConsoleColor.DarkYellow;
            Console.CursorVisible = true;
            //Console.WriteLine("[] Create your Warrior's name: ");
            anima.anima1("[] Create your adventurer's name: ");

#pragma warning disable CS8601 // Possible null reference assignment.
            Player.Player_name = Console.ReadLine(); 
#pragma warning restore CS8601 // Possible null reference assignment.
            Console.SetCursorPosition(10,10);
            anima.anima1("Owww you must be",$"{Player.Player_name}"); 
            Console.SetCursorPosition(1,1);
            

            Console.WriteLine("\n\n\t Press any key to Continue");
            Console.ReadLine();


        }

        public static void TitleScreen(){
            Console.Clear();
            Console.SetCursorPosition(13,1);
            Console.Clear();
             string a = """
████████╗██╗  ██╗███████╗    ██╗      ██████╗ ███████╗████████╗    ██╗  ██╗███████╗██████╗ ██████╗  ██████╗ ███╗   ██╗
╚══██╔══╝██║  ██║██╔════╝    ██║     ██╔═══██╗██╔════╝╚══██╔══╝    ██║  ██║██╔════╝██╔══██╗██╔══██╗██╔═══██╗████╗  ██║
   ██║   ███████║█████╗      ██║     ██║   ██║███████╗   ██║       ███████║█████╗  ██████╔╝██████╔╝██║   ██║██╔██╗ ██║
   ██║   ██╔══██║██╔══╝      ██║     ██║   ██║╚════██║   ██║       ██╔══██║██╔══╝  ██╔══██╗██╔══██╗██║   ██║██║╚██╗██║
   ██║   ██║  ██║███████╗    ███████╗╚██████╔╝███████║   ██║       ██║  ██║███████╗██║  ██║██║  ██║╚██████╔╝██║ ╚████║
   ╚═╝   ╚═╝  ╚═╝╚══════╝    ╚══════╝ ╚═════╝ ╚══════╝   ╚═╝       ╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝ ╚═════╝ ╚═╝  ╚═══╝
""";

// anima.Title_and_gameover(a); --> Need to revamp
Console.WriteLine(a);
Console.WriteLine("\n\n\n\n");
layout.Reset_or_Center(">>Press any Key to continue<<");
Console.ReadLine();
Console.Clear();
            
        }

        public static void Game_Over(){
            Console.Clear();
            string a = """"  
  ▄████  ▄▄▄       ███▄ ▄███▓▓█████     ▒█████   ██▒   █▓▓█████  ██▀███  
 ██▒ ▀█▒▒████▄    ▓██▒▀█▀ ██▒▓█   ▀    ▒██▒  ██▒▓██░   █▒▓█   ▀ ▓██ ▒ ██▒
▒██░▄▄▄░▒██  ▀█▄  ▓██    ▓██░▒███      ▒██░  ██▒ ▓██  █▒░▒███   ▓██ ░▄█ ▒
░▓█  ██▓░██▄▄▄▄██ ▒██    ▒██ ▒▓█  ▄    ▒██   ██░  ▒██ █░░▒▓█  ▄ ▒██▀▀█▄  
░▒▓███▀▒ ▓█   ▓██▒▒██▒   ░██▒░▒████▒   ░ ████▓▒░   ▒▀█░  ░▒████▒░██▓ ▒██▒
 ░▒   ▒  ▒▒   ▓▒█░░ ▒░   ░  ░░░ ▒░ ░   ░ ▒░▒░▒░    ░ ▐░  ░░ ▒░ ░░ ▒▓ ░▒▓░
░       ░      ░  ░       ░ ░        ░     ░  ░   ░                                                                                                                                                                                                           
"""";

            //anima.Title_and_gameover(a);
            Console.WriteLine(a);
        }
        public static void EndingScreen(){
            Console.Clear();
            string a = """
,--,--'.        .-,--.       . 
`- |   |-. ,-.   `\__  ,-. ,-| 
 , |   | | |-'    /    | | | | 
 `-'   ' ' `-'   '`--' ' ' `-^ 
                               
""";
anima.Title_and_gameover(a);
        }
    }

  
}