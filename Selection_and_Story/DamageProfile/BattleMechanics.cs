

using player;
using enemy;


namespace Battle_Mechanics{
    class healthBar{ // This class is used as a battle arena algorithm  ---> Must be always called inside the story class

    public static int healthbar_position = 30;


    public static void Battle(){

        int turns = 5;
        Console.CursorVisible = false;

        while (turns != 0){ // Healthbar of the player
            //Console.Clear();

            Console.SetCursorPosition(healthbar_position, 15); // w / h
             for (int a = 0; a <= Player.battle_health; ++a){
              
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Write("#");
                
                Console.ResetColor();
               
              
            }
            Console.Write("                                        "); // => The easiest solution on deleting a certain part in the console
            Console.SetCursorPosition(healthbar_position,17);// --------------w / h --------------------
            for (int b = 0; b <= Enemy_Health.generic_test; ++b){ // Health bar of the enemy
            
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Write("#");
                Console.ResetColor();
               
            }
            Console.Write("                                        ");

            ConsoleKeyInfo user_pressed = Console.ReadKey();

            switch (user_pressed.Key){

                case ConsoleKey.Y : Player.health -= 10; break;
                case ConsoleKey.E: Enemy_Health.generic_test -= 10; break;

            }

            layout.border_layout();


            turns -= 1;

        }        

    }
}
}