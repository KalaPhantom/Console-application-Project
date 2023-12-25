

using player;



namespace Battle_Mechanics{ 
    class healthBar{ // This class is used as a battle arena algorithm  ---> Must be always called inside the story class --
                     // This is responsible for updating all of the info in the player and enemy info pannels 

    public static int healthbar_position = 35;


    public static void Battle(int Enemy_Health, int dmg,int pl_dodge_rate, int en_attack_rate, int en_dodge_rate, string enemy_name){ 

     
            Console.CursorVisible = false;
            layout.Battle_layout();

            // To assig the value in this method  -- h -> position in y || w --> position in x || s_h is for the size in y || s_w - size in x
            
            //For player and enemy stats
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.White;
            layout.Box_Generator(5,2,15,25);
            Console.ResetColor();

            // Player name and stats
            int text_post_x = 7;
            int text_post_y =3;

            //player display stats
            Console.SetCursorPosition(text_post_x,text_post_y);
            Console.Write($" \x1b[34m[] {Player.Player_name}\x1b[0m"); // name
            Console.SetCursorPosition(text_post_x,text_post_y + 1);
            Console.Write($"* HP: {(Player.battle_health >20 ? $"\x1b[36m{Player.battle_health}\x1b[0m": $"\x1b[31m{Player.battle_health}\x1b[0m")}");
            Console.SetCursorPosition(text_post_x,text_post_y+2);
            Console.Write($"* Attack damage: \x1b[31m{Player.damage}\x1b[0m");
            Console.SetCursorPosition(text_post_x,text_post_y+3);
            Console.Write($"* Dodge rate: \x1b[33m{pl_dodge_rate}\x1b[0m");
            Console.SetCursorPosition(text_post_x,text_post_y+4);
            Console.Write($"* Attribute: {(Player.Is_pl_poisoned == true? "\x1b[m32Poisoned\x1b[0m]" : "Normal")} ");


            // Enemy display stats

            Console.SetCursorPosition(text_post_x,text_post_y +6);
             Console.Write($" \x1b[31m[] {enemy_name}\x1b[0m"); // name
            Console.SetCursorPosition(text_post_x,text_post_y +7);
            Console.Write($"* HP: {(Enemy_Health >20 ? $"\x1b[33m{Enemy_Health}\x1b[0m": $"\x1b[31m{Enemy_Health}\x1b[0m")}");
            Console.SetCursorPosition(text_post_x,text_post_y +8);
            Console.Write($"* Attack damage: \x1b[31m{dmg}\x1b[0m");
            Console.SetCursorPosition(text_post_x,text_post_y +9);
            Console.Write($"* Attack rate: \x1b[31m{en_attack_rate}\x1b[0m");
            Console.SetCursorPosition(text_post_x,text_post_y +10);
            Console.Write($"* dodge rate: \x1b[31m{en_dodge_rate}\x1b[0m");



            Console.SetCursorPosition(healthbar_position, 14); // w / h
            Console.Write($"\x1b[34m[] {Player.Player_name}\x1b[0m");
            Console.SetCursorPosition(healthbar_position, 15); // w / h
             for (int a = 0; a <= Player.battle_health; ++a){
                Thread.Sleep(1);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Write("#");
                
                Console.ResetColor();
            }
           
            Console.Write("                                "); // => The easiest solution on deleting a certain part in the console
            Console.SetCursorPosition(healthbar_position,16);
            Console.Write($"\x1b[31m[] {enemy_name}\x1b[0m");

            Console.SetCursorPosition(healthbar_position,17);// --------------w / h --------------------
            for (int b = 0; b <= Enemy_Health; ++b){ // Health bar of the enemy
                Thread.Sleep(1);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Write("#");
                Console.ResetColor();
               
            }
            Console.Write("                              ");
      
;

        }        

    
    }
}