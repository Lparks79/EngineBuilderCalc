using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace EngineBuilderCalc
{
    [Activity(Label = "Engine Builder Home", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        Button crankshaftBtn;
        Button engineBlockBtn;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.EngineBuilderHomeView);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);
            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };

            FindViews();

            HandleEvents();
        }

        private void HandleEvents()
        {
            crankshaftBtn.Click += CrankshaftBtn_Click;
            engineBlockBtn.Click += EngineBlockBtn_Click1;
        }

        private void EngineBlockBtn_Click1(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(EngineBlockActivity));
            StartActivity(intent);
        }

        private void FindViews()
        {
            crankshaftBtn = FindViewById<Button>(Resource.Id.CrankshaftBtn);
            engineBlockBtn = FindViewById<Button>(Resource.Id.EngineBlockBtn);
        }

        private void CrankshaftBtn_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(CrankshaftActivity));
            StartActivity(intent);
        }
    }
}

