using System.Data.Common;
using player;
using Story;
using Testtt_1;
using Death;
using Game;
using System.Threading;
using System.Runtime.CompilerServices;
using Sound;
using Simulations;


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
                SfX.MainBg2();
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

                  while (Player.Pl_alive == true){  // Dialogue Callings ----------------------------------------------------------------------------------->
                    story.Tutorials();
                    story.Intro1();
                    if (Player.health <=0){Batte_Simulation.deth_in_story_mid = true; break;}
                    story.Dialogue_1();
                    if (Player.health <=0){Batte_Simulation.deth_in_story_mid = true; break;}
                    story.Dialogue_2();
                    if (Player.health <=0){Batte_Simulation.deth_in_story_mid = true; break;}
                    story.Dialogue_3();
                    if (Player.health <=0){Batte_Simulation.deth_in_story_mid = true; break;}
                    story.Dialogue_4();
                    if (Player.health <=0){Batte_Simulation.deth_in_story_mid = true; break;}
                    story.Dialogue_5();
                    if (Player.health <=0){Batte_Simulation.deth_in_story_mid = true; break;}
                    story.Dialogue_5_5();
                    if (Player.health <=0){Batte_Simulation.deth_in_story_mid = true; break;}
                    story.Dialogue_7();
                    if (Player.health <=0){Batte_Simulation.deth_in_story_mid = true; break;}
                    story.Dialogue_8();
                    if (Player.health <=0){Batte_Simulation.deth_in_story_mid = true; break;}
                    story.Dialogue_10();
                    if (Player.health <=0){Batte_Simulation.deth_in_story_mid = true; break;}
                    story.Dialogue_11();
                    if (Player.health <=0){Batte_Simulation.deth_in_story_mid = true; break;}
                    story.Dialogue_12();
                    if (Player.health <=0){Batte_Simulation.deth_in_story_mid = true; break;}
                    Player.Pl_alive = false;       
                           
                  }
                  Player.Pl_alive = true;
                  Batte_Simulation.deth_in_story_mid = false;
                  Player.Is_pl_poisoned = false;


                  story.Ending_and_epilogues();
                  story.EndingStats();
                              
                  Console.Clear();
                   // Call test for the title screens
                  End.End_screen();
                  Console.ReadKey();

                  Console.Clear();
                  layout.border_layout();
                  Console.Write("\t>>Press Esc button to exit to the console \n\t>>Press Enter to Go back to the title screen...... ");
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
