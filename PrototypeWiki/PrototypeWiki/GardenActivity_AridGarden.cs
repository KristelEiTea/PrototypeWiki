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
    [Activity(Label = "GardenActivity_AridGarden")]
    public class GardenActivity_AridGarden : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.GardenLayout_AridGarden);
            // Create your application here
            var aridAgaveDrop = FindViewById<ImageButton>(Resource.Id.aridAgaveDrop);

            aridAgaveDrop.Click += AridAgaveDrop_Click;
        }

        private void AridAgaveDrop_Click(object sender, EventArgs e)
        {
            var item_agave = new Intent(this, typeof(Item_AgaveActivity));
            StartActivity(item_agave);
        }
    }
}