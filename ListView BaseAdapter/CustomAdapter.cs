using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Object = Java.Lang.Object;

namespace ListView_BaseAdapter
{
    class CustomAdapter : BaseAdapter
    {
        private Context c;
        private JavaList<Fruit> fruits;
        private LayoutInflater inflater;

        public CustomAdapter(Context c, JavaList<Fruit> fruits)
        {
            this.c = c;
            this.fruits = fruits;
        }


        public override Object GetItem(int position)
        {
            return fruits.Get(position);
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            if (inflater == null)
            {
                inflater = (LayoutInflater) c.GetSystemService(Context.LayoutInflaterService);
            }

            if (convertView == null)
            {
                convertView = inflater.Inflate(Resource.Layout.Model, parent, false);
            }

            //BIND DATA
            MyHolder holder=new MyHolder(convertView);
            holder.NameTxt.Text = fruits[position].Name;
            holder.Img.SetImageResource(fruits[position].Image);

            convertView.SetBackgroundColor(Color.LightBlue);

            return  convertView;
        }

        public override int Count
        {
            get { return fruits.Size(); }
        }
    }
}