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
            var itemPot = FindViewById<ImageButton>(Resource.Id.agaveItemPot);

            itemPot.Click += ItemPot_Click;
        }

        private void ItemPot_Click(object sender, EventArgs e)
        {
            var item_pot = new Intent(this, typeof(Item_PotActivity));
            StartActivity(item_pot);
        }
    }
}