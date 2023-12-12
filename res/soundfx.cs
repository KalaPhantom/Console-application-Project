
using System.Media;

namespace Sound{
     class SfX{
        public static void SfX1(){

            string FilePath = @"SFX\pianos-by-jtwayne-7-174717.wav"; // -> Places the file location of the sound
            // Create a SoundPlayer instance
            // Make sure to only copy the relative path
            using (var soundPlayer = new SoundPlayer(FilePath)) // -> Using the SoundPlayer to create an instance for the file path
            // Play the sound
            soundPlayer.Play(); // Play the sound file
         }
         public static void Selection1(){
            string FilePath = @"SFX\untitled.wav";
             using (var soundPlayer = new SoundPlayer(FilePath)) soundPlayer.Play();        
         }
    }
}
   