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
    [Activity(Label = "Categories", Theme = "@style/AppTheme")]
    public class Categories : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Categories);
            Title = "Categories";
            // Create your application here
            var gardenButton = FindViewById<ImageButton>(Resource.Id.gardenButton);

            gardenButton.Click += GardenButton_Click;
        }

        private void GardenButton_Click(object sender, EventArgs e)
        {
            var Gardens = new Intent(this, typeof(GardenActivity));
            StartActivity(Gardens);
        }
    }
}