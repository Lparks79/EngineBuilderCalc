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

namespace EngineBuilderCalc
{
    [Activity(Label = "EngineBlock")]
    public class EngineBlockActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.EngineBlockSpecs);
            Button button = FindViewById<Button>(Resource.Id.ConvertLiterToCC);
            EditText literText = FindViewById<EditText>(Resource.Id.engineLiter);
            EditText ccText = FindViewById<EditText>(Resource.Id.engineCC);
            button.Click += delegate { ccText.Text = Convert.ToString(Convert.ToDecimal(literText.Text) * 1000); };
        }
    }
}