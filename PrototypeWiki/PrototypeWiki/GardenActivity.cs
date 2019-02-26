using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace PrototypeWiki
{
    [Activity(Label = "GardenActivity")]
    public class GardenActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.GardenLayout);
            // Create your application here
            var aridGarden = FindViewById<ImageButton>(Resource.Id.aridGarden);
            var aboutGardens = FindViewById<ImageButton>(Resource.Id.aboutGardens);

            aridGarden.Click += AridGarden_Click;
            aboutGardens.Click += AboutGardens_Click;
        }

        private void AboutGardens_Click(object sender, EventArgs e)
        {
            var about_gardens = new Intent(this, typeof(GardenActivity_AboutGardens));
            StartActivity(about_gardens);
        }

        private void AridGarden_Click(object sender, EventArgs e)
        {
            var arid_garden = new Intent(this, typeof(GardenActivity_AridGarden));
            StartActivity(arid_garden);
        }
    }
}