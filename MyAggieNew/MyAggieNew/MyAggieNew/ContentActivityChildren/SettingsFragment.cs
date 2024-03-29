﻿using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using SupportToolbar = Android.Support.V7.Widget.Toolbar;
using SupportFragment = Android.Support.V4.App.Fragment;
using Android.Support.V7.App;
using Android.Support.V4.Widget;
using System.Collections.Generic;

namespace MyAggieNew
{
    public class SettingsFragment : Android.Support.V4.App.Fragment
    {
        public SettingsFragment() { }

        public static Android.Support.V4.App.Fragment newInstance(Context context)
        {
            SettingsFragment busrouteFragment = new SettingsFragment();
            return busrouteFragment;
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            ViewGroup root = (ViewGroup)inflater.Inflate(Resource.Layout.fragment_content_settings, null);
            return root;
        }
    }
}