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
    [Activity(Label = "RecipeSugar_AgavePotActivity")]
    public class RecipeSugar_AgavePotActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.RecipeSugar_AgavePot);
            // Create your application here
            var itemPot = FindViewById<ImageButton>(Resource.Id.AgaveSugarRecipePot);
            var agave = FindViewById<ImageButton>(Resource.Id.AgaveSugarRecipeAgave);

            itemPot.Click += ItemPot_Click;
            agave.Click += Agave_Click;
        }

        private void Agave_Click(object sender, EventArgs e)
        {
            var item_agave = new Intent(this, typeof(Item_AgaveActivity));
            StartActivity(item_agave);
        }

        private void ItemPot_Click(object sender, EventArgs e)
        {
            var item_pot = new Intent(this, typeof(Item_PotActivity));
            StartActivity(item_pot);
        }
    }
}