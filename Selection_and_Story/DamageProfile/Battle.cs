
using player;
using enemy;
using Battle_Mechanics;
using Selection;
using Story;
using Sound;


namespace Simulations{ 
    class Batte_Simulation{
        public static bool deth_in_story_mid = false;

        public static bool is_pl_defeated = false;
        public static bool is_player_fled = false;
        public static int pl_escape_count = 0;
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
      
         public static void battle1(int a, int b,int c, int d, int e, string cc){ // Enemy-- Where a = for the enemy health ||| b is for the enemy damage ||| c is for the enemy dodge rate ||| d is for the enemy attack rate || e is for the enemy miss rate
         
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor= ConsoleColor.DarkCyan;
           layout.Box_Generator(34,2,4,80);
           Console.ResetColor();

            while ( Player.Pl_alive== true && Enemy.En_alive == true){
                Random dmg_e = new Random();
                int en_actions = dmg_e.Next(1,100); // Random Percentage
                int pl_actions = dmg_e.Next(1,100); // Random Percentage 
                int en_attack = dmg_e.Next(1,2); // Random attack attributer 
                int pl_attack = dmg_e.Next(1,2); // Random attack attributer
                int en_miss_chances = dmg_e.Next(1,100);
                int player_flee = dmg_e.Next(1,100);
             

                

                // HP Visualization
                healthBar.Battle(a,b,pl_actions,d,c,cc);
              
               
                Thread.Sleep(5);

            
                // Battle event
                bool enemy_dodge = false;
                 // needed to be assigned so the enemy can also miss an attack bay 30 percent or depends on the enemy algorithm
               

                system_selection.sel_2_battle("Attack","Dodge","Flee"); // Called for the selection
                switch(system_selection.battle_sel_option){

                    case 1: // Player attack choice

                   
                        action_box_resetter(); action_box_pos(); anima.anima1("You choose to attack");
                        switch(en_actions <c? "attack" : en_actions >d? "dodge": "attack" ){ // Random enemy response
                            case "attack":  
                            SfX.Punch();
                            if (enemy_dodge == false){a -= Player.damage*pl_attack; action_box_resetter(); action_box_pos(); Console.Write("You hit the enemy !!!"); healthBar.Battle(a,b,pl_actions,d,c,cc); }// Player attack
                            if(en_miss_chances>e){ Player.battle_health -= b  *en_attack; action_box_resetter(); action_box_pos(); SfX.Punch(); anima.anima1("The enemy manages to retaliate"); healthBar.Battle(a,b,pl_actions,d,c,cc);  }//Enemy retalliate
                            else if(en_miss_chances < e){action_box_resetter(); action_box_pos(); anima.anima1("The enemy attack but misses"); Thread.Sleep(1000);}
                           
                            break; // enemy attack
                            case "dodge": enemy_dodge = true; action_box_resetter(); action_box_pos(); Thread.Sleep(1000); SfX.Dodge(); anima.anima1("Enemy dodged your attack and retaliates"); Player.battle_health -= b  *en_attack;  healthBar.Battle(a,b,pl_actions,d,c,cc); break;
                    
                         }
                          if (enemy_dodge == true) { enemy_dodge = false; }
                          
                    break;

                    case 2: // Player dodge choice 
                        switch (pl_actions <60? "Dodge" : pl_actions > 60?"Fail": "Dodge"){
                            case "Dodge": SfX.Dodge();action_box_resetter(); action_box_pos(); Console.WriteLine("you dodged the enemy");break;
                            case "Fail": SfX.Punch(); action_box_resetter(); action_box_pos();anima.anima1("You failed to dodge");  Player.battle_health -= b  *en_attack; break; 
                        }
                     break;
                    case 3: action_box_resetter(); action_box_pos(); anima.anima1("You tried to flee . . . . . . "); Thread.Sleep(500);

                    switch (player_flee < 10? "flee" : "fail"){
                        case "flee": action_box_resetter(); action_box_pos(); anima.anima1("You flee successfully"); is_player_fled = true; Thread.Sleep(1000); action_box_resetter(); action_box_pos() ;break;
                        default: action_box_resetter(); action_box_pos(); Player.battle_health -= b  *en_attack;anima.anima1("You fail to flee"); break;
                    }
                    break;
                }

                if (is_player_fled == true){
                    is_player_fled = false;
                    pl_escape_count += 1;
                   
                    break;
                }

                if (Player.Is_pl_poisoned == true){
                    action_box_resetter(); action_box_pos(); anima.anima1("The Poison starts to damage you"); Thread.Sleep(500); Player.battle_health -= 5; 
                }
                
              
                if (a <= 0 && Player.health >0){
                    Enemy.En_alive = false;
                    action_box_resetter(); action_box_pos();
                    anima.anima1("Enemy defeated . . . . . ");
                    healthBar.Battle(a,b,pl_actions,d,c,cc);
                    Player.Slained_enemy_count +=1; Thread.Sleep(1000);
                    action_box_resetter(); action_box_pos();
                    anima.anima1("Battle XP +100"); story.battle_xp += 100;
                    

                }
                else if (Player.battle_health <= 0 && a >0){
                    healthBar.Battle(a,b,pl_actions,d,c,cc);
                    action_box_resetter(); action_box_pos();
                    anima.anima1("Fail - - "); // 
                    action_box_pos_s2();
                    anima.anima1("You have been defeated . . . . .");
                    Player.Pl_alive = false; Thread.Sleep(1000);
                    Player.health -= 1; // Lessens the player overall health count out of maximum value 
                    Console.Title = $"HP {Player.health}";
                    Console.Clear();
                    layout.border_layout();
                    anima.anima1($"You have \u001b[31m{Player.health}\u001b[0m health remaining");
                    Console.WriteLine(); Thread.Sleep(1000);
                    is_pl_defeated = true; action_box_resetter(); action_box_pos(); anima.anima1("\n\tBattle XP +5"); story.battle_xp += 5; Player.Loss_count +=1;
                    Console.WriteLine();
                }
                else if (a <= 0 && Player.health <= 0){
                    action_box_resetter(); action_box_pos();
                    Thread.Sleep(2000);
                    anima.anima1("Draw.......................");

                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.White;

                if (cc != "Dragon" && Player.health == 0){deth_in_story_mid = true;}
              
                
                

                Console.ResetColor();
            }
            
            // Player and enemy attribute resetter
            Player.battle_health = 50;
            Player.Pl_alive = true;
            Enemy.En_alive = true;

            action_box_pos();

        }
        
    }
}