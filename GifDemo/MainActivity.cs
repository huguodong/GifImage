using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Com.Ant.Liao;
namespace GifDemo
{
    [Activity(Label = "GifDemo", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity, ImageView.IOnClickListener
    {

        private Com.Ant.Liao.GifView gif;
        private Boolean f = true;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            gif = FindViewById<Com.Ant.Liao.GifView>(Resource.Id.gif1);
            //gif.SetShowDimension(500, 500);
            gif.SetGifImageType(Com.Ant.Liao.GifView.GifImageType.Cover);
            gif.SetGifImage(Resource.Drawable.demo);
            gif.SetOnClickListener(this);
        }

        public void OnClick(View v)
        {
            if (f)
            {
                gif.ShowCover();
                f = false;
            }
            else
            {
                gif.ShowAnimation();
                f = true;
            }
        }
    }
}

