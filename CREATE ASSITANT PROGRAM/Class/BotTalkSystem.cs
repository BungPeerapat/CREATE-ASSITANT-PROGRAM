using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech;
using System.Speech.Recognition;
using System.Windows.Forms;
using WMPLib;
using CREATE_ASSITANT_PROGRAM.Class;
using System.IO;

namespace CREATE_ASSITANT_PROGRAM
{
    internal class BotTalkSystem
    {
        public static void BTS()
        {
            Console.Beep();
            // Create an in-process speech recognizer for the en-US locale.  
            using (
            SpeechRecognitionEngine recognizer =
              new SpeechRecognitionEngine(
                new System.Globalization.CultureInfo("en-UN")))
            {

                // Create and load a dictation grammar.  
                recognizer.LoadGrammar(new DictationGrammar());

                // Add a handler for the speech recognized event.  
                recognizer.SpeechRecognized +=
                  new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);

                // Configure input to the speech recognizer.  
                recognizer.SetInputToDefaultAudioDevice();

                // Start asynchronous, continuous speech recognition.  
                recognizer.RecognizeAsync(RecognizeMode.Multiple);

                // Keep the console window open.  
                while (true)
                {
                    Console.ReadLine();
                }
            }
        }
        // Handle the SpeechRecognized event.  
        public static string SendText;

        private static void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            Console.WriteLine("Recognized text: " + e.Result.Text);
            if (e.Result.Text == "they" || e.Result.Text == "They")
            {

                SendText = "Test";
                MessageBox.Show(SendText);
                System.IO.Stream str = Properties.Resources.แนะนำตัว;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
            }
            if (e.Result.Text == "Sure" || e.Result.Text == "sure")
            {
                SendText = " TextOpen ";
                MessageBox.Show(SendText);
                Console.Beep();
                Text_Control TC = new Text_Control();
                TC.Show();
            }
        }
    }
}
