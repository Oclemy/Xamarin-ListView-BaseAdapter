using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ListView_BaseAdapter
{
    [Activity(Label = "ListView_BaseAdapter", MainLauncher = true, Icon = "@drawable/simplesmile")]
    public class MainActivity : Activity
    {

        private ListView lv;
        private CustomAdapter adapter;
        private JavaList<Fruit> fruits; 

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            lv = FindViewById<ListView>(Resource.Id.lv);



            adapter=new CustomAdapter(this,GetFruits());

            lv.Adapter = adapter;

            lv.ItemClick += lv_ItemClick;


        }

        void lv_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Toast.MakeText(this,fruits[e.Position].Name,ToastLength.Short).Show();
        }

        private JavaList<Fruit> GetFruits()
        {
            fruits = new JavaList<Fruit>();

            Fruit f;

            f = new Fruit("Apple", Resource.Drawable.apples);
            fruits.Add(f);

            f = new Fruit("Oranges", Resource.Drawable.oranges);
            fruits.Add(f);

            f = new Fruit("Pineapple", Resource.Drawable.pineapple);
            fruits.Add(f);

            f = new Fruit("Apples", Resource.Drawable.apples);
            fruits.Add(f);

            f = new Fruit("Mango", Resource.Drawable.mango);
            fruits.Add(f);

            f = new Fruit("Grapes", Resource.Drawable.grapes);
            fruits.Add(f);




            return fruits;

        }
    }
}

