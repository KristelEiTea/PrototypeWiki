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

            sugarRecipe.Click += sugarRecipe_Click;
        }

        private void sugarRecipe_Click(object sender, EventArgs e)
        {
            var sugar_Recipe = new Intent(this, typeof(RecipeSugar_AgavePotActivity));
            StartActivity(sugar_Recipe);
        }
    }
}