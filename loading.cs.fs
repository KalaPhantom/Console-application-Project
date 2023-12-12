namespace Testtt_1
{
    class progress_bar
    {

        public static void bar1()
        {

            for (int i = 0; i <= 50; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    string boom_bars = "\u2551";
                    Console.Write(boom_bars);
                }
                Console.Write(" {0}/50", i);
                Console.SetCursorPosition(1, 12);
                Thread.Sleep(20);
                

            }
           
         
        }

    }
}