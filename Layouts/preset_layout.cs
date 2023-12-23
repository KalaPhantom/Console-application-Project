using System.IO.Compression;
using Selection;
using Testtt_1;

class layout_preset{


    public static void diff_selection(){
        Console.Clear();
        layout.border_layout_1();
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.White;
        layout.Box_Generator(2,3,19,30);
        Console.ResetColor();

        Console.ForegroundColor= ConsoleColor.White;
        Console.SetCursorPosition(63,5); // 
        Console.Write("Difficulty Info");


        Console.SetCursorPosition(5,5);
        Console.Write("Select your difficulty");
        Console.ResetColor();

         Console.SetCursorPosition(5,10);
        system_selection.sel_3_diff("Easy","Normal","Despair");
        layout.border_layout_1();
        switch (system_selection.sel_option){
            case 1: menu.option = 1; break;
            case 2: menu.option = 2; break;
            case 3: menu.option = 3; break;
        }

        

        Console.ReadKey();
        Console.ResetColor();

    }





}