class decorations{

    public static void headphone(){
        layout.border_layout();
        Console.SetCursorPosition(10,5);
        Console.Write("  \t\t");
        Console.Write("""  

                            .........
                         |************#
                        |**          **#
                        |**          **#
                        |**          **#
                        |**          **#
                      |{###+          ###^}
                      |{###+          ###^}
        """);
        Console.SetCursorPosition(10,1);
        anima.anima1(" \t\tThis Console Game has sounds on it \n", "\n\tPress any key to continue ....");
        Console.ReadLine();
        
    }
    public static void damage_decorator(){

        for (int a = 0; a < 2; a++){
            
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Thread.Sleep(500);
            Console.ResetColor();
            
        }
        
    }


}