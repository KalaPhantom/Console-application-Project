
using System.Media;

namespace Sound{
     class SfX{
        public static void SfX1(){

            string FilePath = @"Selection_and_Story\SFX\pianos-by-jtwayne-7-174717.wav"; // -> Places the file location of the sound
            // Create a SoundPlayer instance
            // Make sure to only copy the relative path
            using (var soundPlayer = new SoundPlayer(FilePath)) // -> Using the SoundPlayer to create an instance for the file path
            // Play the sound
            soundPlayer.Play(); // Play the sound file
         }
         public static void Selection1(){
            string FilePath = @"Selection_and_Story\SFX\untitled.wav";
             using (var soundPlayer = new SoundPlayer(FilePath)) soundPlayer.Play();        
         }

          public static void Selection1(string a){ // Returns an optional player// An overload
            string FilePath = a;
             using (var soundPlayer = new SoundPlayer(FilePath)) soundPlayer.Play();        
         }
    }
}