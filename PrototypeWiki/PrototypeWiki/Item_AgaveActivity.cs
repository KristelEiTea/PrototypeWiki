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
    [Activity(Label = "Item_AgaveActivity")]
    public class Item_AgaveActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Item_Agave);
            // Create your application here
            var sugarRecipe = FindViewById<ImageButton>(Resource.Id.AgaveSugarRecipeImageButton);
            var pemmicanRecipe = FindViewById<ImageButton>(Resource.Id.AvagePemmicanRecipeImageButton);

            sugarRecipe.Click += sugarRecipe_Click;
            pemmicanRecipe.Click += PemmicanRecipe_Click;
        }

        private void PemmicanRecipe_Click(object sender, EventArgs e)
        {
            var pemmican_Recipe = new Intent(this, typeof(RecipePemmican_AgaveCookedChickenHoneyPeanutPotActivity));
            StartActivity(pemmican_Recipe);
        }

        private void sugarRecipe_Click(object sender, EventArgs e)
        {
            var sugar_Recipe = new Intent(this, typeof(RecipeSugar_AgavePotActivity));
            StartActivity(sugar_Recipe);
        }
    }
}