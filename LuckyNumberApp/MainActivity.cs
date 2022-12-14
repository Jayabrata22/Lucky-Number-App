using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Widget;
using Android.Support.V4.App;
using System;

namespace LuckyNumberApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        SeekBar seekBar;
        TextView resultTextView;
        Button pushButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            // Set our view from the "main" layout resour ce
            SetContentView(Resource.Layout.activity_main);
            seekBar = FindViewById<SeekBar>(Resource.Id.seekBar);
            resultTextView = FindViewById<TextView>(Resource.Id.resultTextView);
            pushButton = (Button)FindViewById(Resource.Id.pushButton);
            pushButton.Click += PushButton_Click;
        }

        private void PushButton_Click(object sender, System.EventArgs e)
        {
            Random random = new Random();
            int LuckyNumber = random.Next(seekBar.Progress) + 1;
            resultTextView.Text = LuckyNumber.ToString();
        }
    }
}