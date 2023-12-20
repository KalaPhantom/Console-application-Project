
using player;
using enemy;
using Battle_Mechanics;


namespace Simulations{
    class Batte_Simulation{




         public static void battle1(int a){ // Wolf

           

            while ( Player.Pl_alive== true && Enemy.En_alive == true){
                Random dmg_e = new Random();
                int en_attack = dmg_e.Next(1,3);
                int pl_attack = dmg_e.Next(1,3);

                healthBar.Battle(a);

                //Player damage 
                Enemy_Health.Wolf_Health -= Player.damage*pl_attack;
                Thread.Sleep(20);
                Console.ReadKey();
                Player.battle_health -= Enemy_Health.Wolf_Damage  *en_attack;
                Thread.Sleep(20);
                
                //Console.WriteLine(enemy_health);
                //Console.WriteLine(player_health);

                if (a == 0){
                    Enemy.En_alive = false;
                    break;

                }
                else if (Player.battle_health == 0){
                    Player.Pl_alive = false;
                    break;

                }


            }

        

        
    









        }




    }
}