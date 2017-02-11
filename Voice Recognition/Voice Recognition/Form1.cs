using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
namespace Voice_Recognition
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        public Form1()
        {
           
              InitializeComponent();
            
        }
      
       
        private void form1_Load(object sender, EventArgs e)
        {

          
 
        }
        private void btnEnable_Click(object sender, EventArgs e)
        {
            Choices commands = new Choices();
            commands.Add(new string[] { "hello", "how are you", "hey","love u","let's take some weed","I am rasib" ,"fuck you","i am mijan","i am tuhin"});

            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);
            Grammar gGrammar = new Grammar(gBuilder);
            recEngine.LoadGrammarAsync(gGrammar);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized +=
                        new EventHandler<SpeechRecognizedEventArgs>
                                       (recEngine_SpeechRecognized);  
           recEngine.RecognizeAsync(RecognizeMode.Multiple);
           synthesizer.SelectVoiceByHints(VoiceGender.Female);
            btnDisable.Enabled = true;
        }
        void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                case "hello":
                    synthesizer.SpeakAsync("hi Rezwan");
                    break;

                case "how are you":
                  synthesizer.SpeakAsync("I am fine. whats about u?");
                    break;
                case "hey":
                   synthesizer.SpeakAsync("what's up???");
                    break;
                case "love u":
                     synthesizer.SpeakAsync("sorry i have a bf");
                    break;
                case "let's take some weed":
                    synthesizer.SpeakAsync("cholo mamaa pinic e jai");
                    break;
                case "I am rasib":
                    synthesizer.SpeakAsync("\n No man your name is putki");
                    break;
                case "i am mijan":
                    synthesizer.SpeakAsync("\n No man you are andree kala");
                    break;
                case "i am tuhin":
                    synthesizer.SpeakAsync("\n No man you are votormol");
                    break;
                case "fuck you":
                    synthesizer.SpeakAsync("oh yes! come on baby.");
                    break;
            }
        }
        private void btnDisable_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsyncStop();
            btnDisable.Enabled = false;
        }
       
    }
}
    
        

       

          

     
        
    

