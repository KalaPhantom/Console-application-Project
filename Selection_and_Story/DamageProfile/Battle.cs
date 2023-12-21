
using player;
using enemy;
using Battle_Mechanics;
using Selection;


namespace Simulations{ 
    class Batte_Simulation{

         public static void battle1(int a, int b,int c, int d, string cc){ // Enemy-- Where a = for the enemy health ||| b is for the enemy damage ||| c is for the enemy dodge rate ||| d is for the enemy attack rate 
           Console.ReadKey();

            while ( Player.Pl_alive== true && Enemy.En_alive == true){
                Random dmg_e = new Random();
                int en_actions = dmg_e.Next(1,100); // Random Percentage
                int pl_actions = dmg_e.Next(1,100); // Random Percentage 
                int en_attack = dmg_e.Next(1,3); // Random attack attributer 
                int pl_attack = dmg_e.Next(1,3); // Random attack attributer
                int enemy_critical = dmg_e.Next(1,100); 

                // HP Visualization
                healthBar.Battle(a);
                // damage magnifier

               
                Thread.Sleep(30);

               

                // Battle event
                bool enemy_dodge = false;
               

                system_selection.sel_2("Attack","Dodge","Flee");
                switch(system_selection.sel_option){

                    case 1: // Player attack choice

                   
                    
                        switch(en_actions <c? "attack" : en_actions >d? "dodge": "attack" ){ // Random enemy response
                            case "attack":  Player.battle_health -= b  *en_attack;  break; // enemy attack
                            case "dodge": enemy_dodge = true; Console.WriteLine("Enemy dodge"); break;
                    
                         }
                          if (enemy_dodge == false){a -= Player.damage*pl_attack; }// Player attack
                          if (enemy_dodge == true) { enemy_dodge = false; }
                          
                    break;

                    case 2: 
                        switch (pl_actions <60? "Dodge" : pl_actions > 60?"Fail": "Dodge"){
                            case "Dodge": Console.WriteLine("you dodged");break;
                            case "Fail": Console.WriteLine("Ypu failed to dodge");  Player.battle_health -= b  *en_attack; break; 
                        }
                     break;
                    case 3: break;

                }



                Thread.Sleep(30);
            
                if (a <= 0){
                    Enemy.En_alive = false;
                    anima.anima1("Enemy defeated . . . . . ");

                }
                else if (Player.battle_health <= 0){
                    anima.anima1("Fail - -  You have been defeated . . . . ."); // Temporary 
                    Player.Pl_alive = false;
                    Player.health -= 1; // Lessens the player overall health count out of maximum value 
                }
            }
            // Player and enemy attribute resetter
            Player.battle_health = 50;
            Player.Pl_alive = true;
            Enemy.En_alive = true;

        

        
    









        }




    }
}