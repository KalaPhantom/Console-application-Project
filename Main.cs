using System.Data.Common;
using player;
using Story;
using Testtt_1;
using Death;
using Game;
using System.Threading;


// This portion is the main activity

namespace tesst_1
{
    internal class Program
    {
     
        public static void Main(string[] args)
        {
          Console.Clear();
          Console.CursorVisible = false;

          bool a = true;

            do{
                Console.WriteLine("\a");
                Console.Clear();
                menu.TitleScreen();
                 
                 layout.border_layout();
            

                 // movement.a = Console.ReadLine();

                 // main menus
                 layout_preset.diff_selection();
                  // account creation
                  Difficulty.Global_difficulty();
                  menu.acc_creation();

                  while (Player.Pl_alive == true){
                // Dialogue Callings ----------------------------------------------------------------------------------->
                    story.Intro1();
                    story.Dialogue_1();
                    story.Dialogue_2();
                    story.Dialogue_3();
                    story.Dialogue_4();
                    story.Dialogue_5();
                    story.Dialogue_5_5();
                    story.Dialogue_7();
                    story.Dialogue_8();
                    story.Dialogue_10();
                    story.Dialogue_11();
                    story.Dialogue_12();
                 
                  }
                              
                  Console.Clear();
                   // Call test for the title screens
                  End.End_screen();
                  Console.Clear();
                  Console.Write(">>Press Esc button to exit to the console \n>>Press Enter to Go back to the title screen...... ");
                  ConsoleKeyInfo key = Console.ReadKey(true);

                  switch (key.Key){
                    case ConsoleKey.Escape:
                    a = false;
                    break;

                    case ConsoleKey.Enter:
                    a = true;
                    break;

                    default:
                    a = false;
                    break;

                  }
            }while (a == true);
        }
    }
}
