
using player;
using enemy;
using Battle_Mechanics;


namespace Simulations{
    class Batte_Simulation{

         public static void battle1(int a, int b,string c){ // Enemy-- Where a = for the enemy health ||| b is for the enemy damage
           Console.ReadKey();

            while ( Player.Pl_alive== true && Enemy.En_alive == true){
                Random dmg_e = new Random();
                int en_attack = dmg_e.Next(1,3);
                int pl_attack = dmg_e.Next(1,3);

                healthBar.Battle(a);
                // damage magnifier
                a -= Player.damage*pl_attack; // Player attack
                Thread.Sleep(20);
                Console.ReadKey();
                Player.battle_health -= b  *en_attack; // enemy attack
                Thread.Sleep(20);
            
                if (a <= 0){
                    Enemy.En_alive = false;

                }
                else if (Player.battle_health <= 0){
                    anima.anima1("Fail - -  You have been defeated . . . . .");
                    Player.Pl_alive = false;
                    Player.health -= 1; // Lessens the player overall health 
                }
            }
            Player.battle_health = 50;
            Player.Pl_alive = true;
            Enemy.En_alive = true;

        

        
    









        }




    }
}