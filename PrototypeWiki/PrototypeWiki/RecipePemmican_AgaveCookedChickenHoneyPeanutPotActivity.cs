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
    [Activity(Label = "RecipePemmican_AgaveCookedChickenHoneyPeanutPotActivity")]
    public class RecipePemmican_AgaveCookedChickenHoneyPeanutPotActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.RecipePemmican_AgaveCookedChickenHoneyPeanutPot);
            // Create your application here
            var agaveItem = FindViewById<ImageButton>(Resource.Id.AgavePemmicanRecipeAgave);
            var cookedChickenItem = FindViewById<ImageButton>(Resource.Id.AgavePemmicanRecipeCoockedChicken);
            var honeyItem = FindViewById<ImageButton>(Resource.Id.AgavePemmicanRecipeHoney);
            var peanutItem = FindViewById<ImageButton>(Resource.Id.AgavePemmicanRecipePeanut);
            var potItem = FindViewById<ImageButton>(Resource.Id.AgavePemmicanRecipePot);

            agaveItem.Click += AgaveItem_Click;
            cookedChickenItem.Click += CookedChickenItem_Click;
            honeyItem.Click += HoneyItem_Click;
            peanutItem.Click += PeanutItem_Click;
            potItem.Click += PotItem_Click;
        }

        private void PotItem_Click(object sender, EventArgs e)
        {
            var item_pot = new Intent(this, typeof(Item_PotActivity));
            StartActivity(item_pot);
        }

        private void PeanutItem_Click(object sender, EventArgs e)
        {
            var item_peanut = new Intent(this, typeof(Item_PeanutActivity));
            StartActivity(item_peanut);
        }

        private void HoneyItem_Click(object sender, EventArgs e)
        {
            var item_honey = new Intent(this, typeof(Item_HoneyActivity));
            StartActivity(item_honey);
        }

        private void CookedChickenItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AgaveItem_Click(object sender, EventArgs e)
        {
            var item_agave = new Intent(this, typeof(Item_AgaveActivity));
            StartActivity(item_agave);
        }
    }
}