using System.Data.Common;
using player;
using Story;
using Testtt_1;
using Death;


// This portion is the main activity

namespace tesst_1
{
    internal class Program
    {
     
        public static void Main(string[] args)
        {

          bool a = true;

            do{
                Console.WriteLine("\a");
                Console.Clear();
                 menu.TitleScreen();
                 
                 layout.border_layout();
            

                 // movement.a = Console.ReadLine();

                 // main menus
                  menu.mainmenu1();
                  // account creation
                  menu.acc_creation();
                  story.Dialogue_1();
                  story.Dialogue_2();
                  
                  
                 
                  // Test damage ------
                  bool dm = true;

                  while (dm == true){
                     //Console.WriteLine("Inflict damage by inputing number");
                     Console.Clear();
                     layout.border_layout();
                     //enemy.Enemy.enemy_damage();
                      progress_bar.healthbar();

                     Console.WriteLine("Continue?? (Y/n)");
                     char an = Convert.ToChar(Console.ReadLine());

                     if (an == 'y' ){
                        dm = true;
                        Console.Clear();
                        enemy.Enemy.enemy_damage();
                        decorations.damage_decorator();
                        layout.border_layout();
                        End.Death();
                        if (Player.health == 0){
                          dm = false;
                          End.Death();
                        }
                     }
                     else {
                      dm = false;
                      Console.Clear();
                      layout.border_layout();
                     }
                  }
                  
      
                  Console.Clear();
                  progress_bar.bar1();
                  Console.Write("\n\nWelcome");
                  Console.Clear();

                  decorations.headphone();
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
