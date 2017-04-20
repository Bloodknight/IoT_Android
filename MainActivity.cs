﻿using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Content;          // for Intent

namespace IoT_Android
{
    [Activity(Label = "IoT_Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        // declaration of UI controls
        private Button _helloButton;
        private EditText _nameInput;
        private TextView _showName;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Assign UI controls
            _helloButton = FindViewById<Button>(Resource.Id.button1);
            _nameInput = FindViewById<EditText>(Resource.Id.editText1);
            _showName = FindViewById<TextView>(Resource.Id.textView1);

            // Functions for UI controls
            _helloButton.Click += (object sender, EventArgs e) =>
            {
                _showName.Text = _nameInput.Text.ToString();

                // create new intent instance for testActivity
                var intent = new Intent(this, typeof(testActivity));

                // load the intent with a parameter containing the string value in showName
                intent.PutExtra("text_entered", _showName.Text);

                // start the activity and pass the parameter to testActivity
                StartActivity(intent);
            };
        }
    }
}

