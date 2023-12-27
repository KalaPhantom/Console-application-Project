
#pragma warning disable
using Sound;

class anima
{

    public static void anima1(string a)
    {
       foreach (char c in a){
       
        Console.Write(c);
        Thread.Sleep(30);
       }
    }
     public static void anima2(string a)
    {
       foreach (char c in a){
        Console.Write(c);
        Thread.Sleep(1/2);
       }
    }
    public static void anima1(string a, string b){ // Accepts two string variable -> preferred with the concatination
        foreach (char c in a){
        Console.Write(c);
        Thread.Sleep(1);
       

       }
       foreach(char d in b){
        Console.Write(" "+ d);
        Thread.Sleep(50);
       }

    }
      public static void anima3(string a, string b,string c){ // Accepts Three string variable -> preferred with the concatination
        foreach (char cc in a){
        Console.Write(c);
        Thread.Sleep(30);
       

       }
       foreach(char d in b){
        Console.Write(d);
        Thread.Sleep(30);
       }
       foreach(char ccc in c){
        Console.Write(ccc);
        Thread.Sleep(30);
       }
       

    }
    public static void anima1(string a, string b,string c, string d){ // Accepts Three string variable -> preferred with the concatination
        foreach (char cc in a){
        Console.Write(cc);
        Thread.Sleep(30);
       }
       foreach(char cccc in b){
        Console.Write(cccc);
        Thread.Sleep(30);
       }
       foreach(char ccc in c){
        Console.Write(ccc);
        Thread.Sleep(30);
       }
        foreach(char cccc in d){
        Console.Write(cccc);
        Thread.Sleep(30);
       }

    }
    public static void Title_and_gameover(string a){
        foreach(char b in a){
            Console.Write(b);
            Thread.Sleep(1);
        }



    }
}

// Not yet applied on the project
   