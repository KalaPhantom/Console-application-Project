

using player;



namespace Battle_Mechanics{
    class healthBar{ // This class is used as a battle arena algorithm  ---> Must be always called inside the story class

    public static int healthbar_position = 30;


    public static void Battle(int Enemy_Health){

     
            Console.CursorVisible = false;

            Console.SetCursorPosition(healthbar_position, 15); // w / h
             for (int a = 0; a <= Player.battle_health; ++a){
                Thread.Sleep(1);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Write("#");
                
                Console.ResetColor();
            }
            Console.Write("                                        "); // => The easiest solution on deleting a certain part in the console
            Console.SetCursorPosition(healthbar_position,17);// --------------w / h --------------------
            for (int b = 0; b <= Enemy_Health; ++b){ // Health bar of the enemy
                Thread.Sleep(1);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Write("#");
                Console.ResetColor();
               
            }
            Console.Write("                                        ");
;

        }        

    
    }
}