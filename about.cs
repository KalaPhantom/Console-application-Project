
using player;

namespace Details
{
    class About{
        public static void About_Screen(){
            Console.Clear();
            layout.border_layout();
            Console.SetCursorPosition(60 ,5);
           Console.WriteLine(layout.Byte1());
            //Console.SetCursorPosition(3,4);
           Console.WriteLine("\t\tCreated By: Allen Lerado\n\t\t Reniel Gahuman \n\t\t Jon Andrei Romulo");
           Console.WriteLine();
           Console.WriteLine("\t\t\tAvailable at\n\t\thttps://github.com/KalaPhantom/Console-App-The-Lost-Herron");
           Console.WriteLine(Player.Player_name);
           Console.SetCursorPosition(1,1);
           layout.border_layout(); 
           
           Console.ReadLine();
           Console.Clear();
         
        }
    }
}