
#pragma warning disable
class decorations{




    public static string Sword = """ 
     ^
     |
     |
     |
    o+o
     0
    """;


    public static string Sword2 =""" 
       /\
      \II/
    (88II88)
      /II\
       II
       II
       II
       II
       \/
    """;


// https://www.asciiart.eu/books/books
    public static string Book = """  

        ,..........   ..........,
     ,..,'          '.'          ',..,
    ,' ,'            :            ', ',
   ,' ,'             :             ', ',
  ,' ,'              :              ', ',
 ,' ,'............., : ,.............', ',
,'  '............   '.'   ............'  ',
 '''''''''''''''''';''';''''''''''''''''''
                    '''
    
""";

public static string Bow = """ 
  (
    \
     )
##-------->       
     )
    /
   (

""";

public static string Herron = """

                //,
               ///i 
             ,/ ).'i    
              |   )-i  
              |   )i 
              '   )i
             /    |- 
        _.-./-.  /z_ 
         `-. >._\ _ );i.
          / `-'/`k-'`u)-'`
         /    )-     
  ,.----'   ) '                       
  /      )1`  
 ///v`-v\v        
/v  

""";


//Available at

//------------------------------------------------
//Thank you for visiting https://asciiart.website/
//This ASCII pic can be found at
//https://www.asciiart.website/index.php?art=objects/castles

public static string Castle_home = """

                 |ZZzzz
                 |
                 |
    |ZZzzz      /^\            |ZZzzz
    |          |~~~|           |
    |        |^^^^^^^|        / \
   /^\       |[]+    |       |~~~|
|^^^^^^^|    |    +[]|       |   |
|    +[]|/\/\/\/\^/\/\/\/\/|^^^^^^^|
|+[]+   |~~~~~~~~~~~~~~~~~~|    +[]|
|       |  []   /^\   []   |+[]+   |
|   +[]+|  []  || ||  []   |   +[]+|
|[]+    |      || ||       |[]+    |
|_______|------------------|_______|
""";



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
            Thread.Sleep(70);
            Console.ResetColor();
            
        }
        
    }


}