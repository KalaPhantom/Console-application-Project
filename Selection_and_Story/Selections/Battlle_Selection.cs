// Use this namesepace for printing the appropriate selection boxes 
namespace Character{
    class New_character{


        public static int options = 1;

        public static void Difficulty_Selection(int width, int height , int position_x , int position_y){ // for the global positions of the box and the sizes
        options = 1;

            bool Is_selecting = true;

            int space_index = width;

            while (Is_selecting == true ){

                if (options == 1){
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    layout.Box_Generator(position_x,position_y,height,width);// w /h // size of the 
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.White;
                    layout.Box_Generator(position_x+space_index *2,position_y,height,width); // Position x and postion y || size in x and y
                    layout.Box_Generator(position_x+space_index *4,position_y,height,width);
                    Console.ResetColor();

                }
                else if(options == 2){
                   Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.White;
                    layout.Box_Generator(position_x,position_y,height,width);// w /h
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                     Console.BackgroundColor = ConsoleColor.Yellow;
                    layout.Box_Generator(position_x+space_index *2,position_y,height,width);
                      Console.ResetColor();

                      Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor =ConsoleColor.White;
                    layout.Box_Generator(position_x+space_index *4,position_y,height,width);
                    Console.ResetColor();
                }
                else if (options == 3){
                    
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.White;
                    layout.Box_Generator(position_x,position_y,height,width);// w /h
                    layout.Box_Generator(position_x+space_index *2,position_y,height,width);
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    layout.Box_Generator(position_x+space_index *4,position_y,height,width);
                    Console.ResetColor();
                }
                 ConsoleKeyInfo userInp = Console.ReadKey();

               

                switch (userInp.Key){


                    case ConsoleKey.LeftArrow:
                    options = options == 1? 3 : options - 1;
                    break;

                    case ConsoleKey.RightArrow:
                    options = options == 3? 1 : options + 1;
                    break;

                    case ConsoleKey.Enter:
                    Is_selecting = false;
                    break;

                }
                Console.WriteLine(options);
            }
        }
          public static void Difficulty_Selection_1(int width, int height , int position_x , int position_y){
            options = 1;

            bool Is_selecting = true;
            int space_index = width;

            while (Is_selecting == true ){

               

                if (options == 1){
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    layout.Box_Generator(position_x,position_y,height,width);// w /h // size of the 
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.White;
                    layout.Box_Generator(position_x+space_index *2,position_y,height,width);
                    layout.Box_Generator(position_x+space_index *4,position_y,height,width);
                    layout.Box_Generator(position_x+space_index *6,position_y,height,width);
                    Console.ResetColor();

                }
                else if(options == 2){
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.White;
                    layout.Box_Generator(position_x,position_y,height,width);// w /h
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    layout.Box_Generator(position_x+space_index *2,position_y,height,width);
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor =ConsoleColor.White;
                    layout.Box_Generator(position_x+space_index *4,position_y,height,width);
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.White;
                    layout.Box_Generator(position_x+space_index *6,position_y,height,width);
                    Console.ResetColor();
                }
                else if (options == 3){
                    
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.White;
                    layout.Box_Generator(position_x,position_y,height,width);// w /h
                    layout.Box_Generator(position_x+space_index *2,position_y,height,width);
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    layout.Box_Generator(position_x+space_index *4,position_y,height,width);
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.White;
                    layout.Box_Generator(position_x+space_index *6,position_y,height,width);
                    Console.ResetColor();
                }
                else if (options == 4){
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.White;
                    layout.Box_Generator(position_x,position_y,height,width);// w /h
                    layout.Box_Generator(position_x+space_index *2,position_y,height,width);
                    layout.Box_Generator(position_x+space_index *4,position_y,height,width);
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    layout.Box_Generator(position_x+space_index *6,position_y,height,width); //
                    Console.ResetColor();

                }
                 ConsoleKeyInfo userInp = Console.ReadKey();

               

                switch (userInp.Key){

                    case ConsoleKey.LeftArrow:
                    options = options == 1? 4 : options - 1;
                    break;

                    case ConsoleKey.RightArrow:
                    options = options == 4? 1 : options + 1;
                    break;

                    case ConsoleKey.Enter:
                    Is_selecting = false;
                    break;

                }
                Console.WriteLine(options);

            }

        }

    }
}