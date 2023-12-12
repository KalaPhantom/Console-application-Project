using player;
using Story;
using Testtt_1;

namespace Death{
    class End{
        public static void Death(){

            if (Player.health == 0){
                Console.Clear();
                menu.Game_Over();
                Console.ReadKey();
            }
            /*if()
                Console.Clear();
                menu.EndingScreen();
                Console.ReadKey();
            }*/
        }
        public static void End_screen(){
            menu.EndingScreen();
        }
    }
}