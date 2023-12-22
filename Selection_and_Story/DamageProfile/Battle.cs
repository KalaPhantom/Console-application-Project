
using player;
using enemy;
using Battle_Mechanics;
using Selection;


namespace Simulations{ 
    class Batte_Simulation{
        public static void action_box_pos(){
            Console.SetCursorPosition(36,4);
        }
        public static void action_box_pos_s2(){
            Console.SetCursorPosition(36,5);

             
        }
        public static void action_box_resetter(){
            Console.SetCursorPosition(36,4);
            Console.Write("                                       ");
            Console.SetCursorPosition(36,5);
            Console.WriteLine("                                    ");                                                   
        }
      
         public static void battle1(int a, int b,int c, int d, string cc){ // Enemy-- Where a = for the enemy health ||| b is for the enemy damage ||| c is for the enemy dodge rate ||| d is for the enemy attack rate 
         

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor= ConsoleColor.DarkCyan;
           layout.Box_Generator(34,2,4,80);
           Console.ResetColor();

            while ( Player.Pl_alive== true && Enemy.En_alive == true){
                Random dmg_e = new Random();
                int en_actions = dmg_e.Next(1,100); // Random Percentage
                int pl_actions = dmg_e.Next(1,100); // Random Percentage 
                int en_attack = dmg_e.Next(1,3); // Random attack attributer 
                int pl_attack = dmg_e.Next(1,3); // Random attack attributer
                int enemy_critical = dmg_e.Next(1,100); 

                // HP Visualization
                healthBar.Battle(a,b, cc);
                // damage magnifier
               
                Thread.Sleep(30);

            
                // Battle event
                bool enemy_dodge = false;
                bool enemy_miss_chances = false; // needed to be assigned so the enemy can also miss an attack bay 30 percent or depends on the enemy algorithm
               

                system_selection.sel_2_battle("Attack","Dodge","Flee"); // Called for the selection
                switch(system_selection.sel_option){

                    case 1: // Player attack choice

                   
                    
                        switch(en_actions <c? "attack" : en_actions >d? "dodge": "attack" ){ // Random enemy response
                            case "attack":  Player.battle_health -= b  *en_attack;  break; // enemy attack
                            case "dodge": enemy_dodge = true; action_box_resetter(); action_box_pos(); anima.anima1("Enemy dodged your attack"); break;
                    
                         }
                          if (enemy_dodge == false){a -= Player.damage*pl_attack; }// Player attack
                          if (enemy_dodge == true) { enemy_dodge = false; }
                          
                    break;

                    case 2: // Player dodge choice 
                        switch (pl_actions <60? "Dodge" : pl_actions > 60?"Fail": "Dodge"){
                            case "Dodge": action_box_resetter(); action_box_pos(); Console.WriteLine("you dodged");break;
                            case "Fail": action_box_resetter(); action_box_pos();anima.anima1("You failed to dodge");  Player.battle_health -= b  *en_attack; break; 
                        }
                     break;
                    case 3: break;

                }

                Thread.Sleep(30);
            
                if (a <= 0){
                    Enemy.En_alive = false;
                    action_box_resetter(); action_box_pos();
                    anima.anima1("Enemy defeated . . . . . ");

                }
                else if (Player.battle_health <= 0){
                    action_box_resetter(); action_box_pos();
                    anima.anima1("Fail - - "); // Temporary 
                    action_box_pos_s2();
                    anima.anima1("You have been defeated . . . . .");
                    Player.Pl_alive = false;
                    Player.health -= 1; // Lessens the player overall health count out of maximum value 
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.White;
                
                

                Console.ResetColor();
            }
            // Player and enemy attribute resetter
            Player.battle_health = 50;
            Player.Pl_alive = true;
            Enemy.En_alive = true;

        }
    }
}