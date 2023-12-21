class layout{
    private const int Height = 20; // unused
    private const int With = 40; // unused

    public static int w;
    public static int h;

    public static int s_h = 10; // Def 7
    public static int s_w = 20; // Def 15

    public static void Layout1() // Unfinished layout
    {
        Console.Clear();
        Console.SetWindowSize(30,20);
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.SetCursorPosition(10,5);
        Console.ResetColor();

        for (int a = 0; a < Console.WindowHeight; a++){
            for (int b = 0; b < a; b++ ){
                Console.WriteLine("#");
            }
            //Console.WriteLine("");
        }
        
    }

    public static void Reset_or_Center(string a ){ // -> center a passed string on the console
        
        Console.SetCursorPosition((Console.WindowWidth - a.Length) / 2, Console.CursorTop); // Takes the argument set in the method , It gets  the value of the with of the console window console, Determines the length of the string to be printed - divides in 2 to get the half of the with of the console.
        Console.WriteLine(a);
        
   
    }

    public static void border_layout(){ // -> Creates a solid layout
         //Console.Clear();

         Console.SetCursorPosition(0,0);
            int aa = 120; // Width 
            int bb = 25; // Height

            //Cursor position

            int def_width = 2;
            int def_height = 2;


            Console.SetWindowSize(aa,bb);
            Console.SetBufferSize(aa,bb);
             Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Gray;
            for (int a = 0; a< Console.WindowWidth -1; a++){
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("#");
                Thread.Sleep(0);
                
            }
              for (int b = 0; b< Console.WindowHeight; b++){
                Console.WriteLine("#");
                
            }
          
            for (int c =0; c < Console.WindowHeight; c++){
                Console.SetCursorPosition(aa-1,c);
                Console.WriteLine("#");

            }

            for (int d = 0; d < Console.WindowWidth ; d++){
                Console.Write("#");

            }
            Console.SetCursorPosition(def_width,def_height);
            Console.ResetColor();

            def_layout();
           
    }
    public static void def_layout(){
        Console.SetCursorPosition(4,4);
    }

   public static void Box_Generator(int w, int h, int s_h, int s_w){



            Console.SetCursorPosition(w,h);

            for (int a = 0; a <= s_w; ++a){// top
                //Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("#");
                //Console.ResetColor();
            }
            for (int b = 0; b <= s_h; ++b){ // left
                //Console.BackgroundColor = ConsoleColor.Gray;
                Console.SetCursorPosition(w,b+h);
                Console.WriteLine("#");
                //Console.ResetColor();
            }
            for (int b = 0; b <= s_h; ++b){ // right
                //Console.BackgroundColor = ConsoleColor.Gray;
                Console.SetCursorPosition(w+s_w,b+h);
                Console.WriteLine("#");
                //Console.ResetColor();
            }
             Console.SetCursorPosition(w,h+s_h);
             
             for (int a = 0; a <= s_w; ++a){// bottom
                //Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("#");
                //Console.ResetColor();
            }
           
        }
        
    
    public static string Byte1(){


        string a = """
        
            ██ ██████  ██    ██ ████████ ███████ 
           ███ ██   ██  ██  ██     ██    ██      
            ██ ██████    ████      ██    █████   
            ██ ██   ██    ██       ██    ██      
            ██ ██████     ██       ██    ███████ 

""";
        return a;
    }




}