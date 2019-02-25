using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace PrototypeWiki
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            //Plan:
            //Peakategooriaid on 9: Garden, Crops, Dairy, Ingredients, Meat, Food, Drinks, Coocking Utensils, Machines
            //Olenevalt kategooriast on alamkategooriaid ka päris palju
            //Kus võimalik, võiks igale asjale pildi juurde lisada
            //Nuppudeks kindlasti pildiga nupud, koos tekstiga. Kasvõi panna paint'is teks juurde
            //Peakategooria ja nende alamate font võiks olla sama, kuid peakategooriad võivad
            //üksteisest erineda.
            //Kuna tuleb väga palju vaateid ja classe ning see läheb väga kiirest
            //segaseks, siis võiks nimetused olla peakategooria järgi. nt:
            //Gardens, Garden_nimi1, Garden_nimi2 jne
            //Buttonid peaksid ühe layout'i peal olema ühesuurused. 
            //Enam-vähem võiks app olla ühes stiilis, väikeste muutustega.

            //Näide/prototüüp on leitav: https://kristeleitea.proto.io/player/?id=b7259ea6-ac2c-433c-8d0e-4ba7c2525a70
            //Avada soovitatavalt Google Chrome'ga!

            //activity_main on esiekraan. Kellel on ideid, andke märku!

            //Alustan Garden'iga tegelemisest! - Kristel
            var startButton = FindViewById<Button>(Resource.Id.startButton);

            startButton.Click += StartButton_Click;
        }

        private void StartButton_Click(object sender, System.EventArgs e)
        {
            var start = new Intent(this, typeof(Categories));
            StartActivity(start);
        }
    }
}