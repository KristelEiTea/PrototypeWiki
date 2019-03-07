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
    [Activity(Label = "Item_HoneyActivity")]
    public class Item_HoneyActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Item_Honey);
            // Create your application here
            var honeycombItem = FindViewById<ImageButton>(Resource.Id.HoneyComb);

            honeycombItem.Click += HoneycombItem_Click;
        }

        private void HoneycombItem_Click(object sender, EventArgs e)
        {
            var item_honeycomb = new Intent(this, typeof(Item_HoneycombActivity));
            StartActivity(item_honeycomb);
        }
    }
}