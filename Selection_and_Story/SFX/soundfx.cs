
using System.Media;

namespace Sound{
     class SfX{
        public static void SfX1(){

#pragma warning disable
            string FilePath = @"Selection_and_Story\SFX\pianos-by-jtwayne-7-174717.wav"; // -> Places the file location of the sound
            // Create a SoundPlayer instance
            // Make sure to only copy the relative path
            // For Published version -> also copy the files in the bin folder
            using (var soundPlayer = new SoundPlayer(FilePath)) // -> Using the SoundPlayer to create an instance for the file path
            // Play the sound
            soundPlayer.Play(); // Play the sound file
         }
         public static void Selection1(){
            /*string FilePath = @"Selection_and_Story\SFX\untitled.wav";
             using (var soundPlayer = new SoundPlayer(FilePath)) soundPlayer.Play(); */

               SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"Selection_and_Story\SFX\untitled.wav";
            player.Play(); 
          
          
                 
         }
         public static void Rorr(){
            string FilePath = @"Selection_and_Story\SFX\dragon-roar-96996.wav";
            string absulute = Path.GetFullPath(FilePath);
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = absulute;
            player.Load();
            player.Play();       
         }
          public static void Punch(){
            string FilePath = @"Selection_and_Story\SFX\Punchh.wav";
            string absulute = Path.GetFullPath(FilePath);
             using (var soundPlayer = new SoundPlayer(absulute)) soundPlayer.Play();  
                 
         }
         public static  void MainBg(){
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"Selection_and_Story\SFX\EndBg.wav";
            player.Load();
            player.Play(); 
          
            
            
         }
         public static  void MainBg2(){
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"Selection_and_Story\SFX\MainBg2.wav";
            player.Load();
            player.Play(); 
            
         }
          public static  void Dodge(){
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"Selection_and_Story\SFX\Dodge.wav";
            player.Play(); 
         }
          public static  void Click(){
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"Selection_and_Story\SFX\click.wav";
            player.Play(); 
         }

          public static  void Ending(){
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"Selection_and_Story\SFX\EndBg.wav";
            player.Load();
            player.Play(); 
           
         }
           public static  void Josh_Hutcherson(){
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"Selection_and_Story\SFX\pianos-by-jtwayne-7-174717.wav";
            player.Load();
            player.Play(); 
           
         }
         
      
     }
}

        
     
     
