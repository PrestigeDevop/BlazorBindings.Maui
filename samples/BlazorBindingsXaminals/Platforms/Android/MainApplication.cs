﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using Android.App;
using Android.Runtime;

namespace BlazorBindingsXaminals;

[Application]
public class MainApplication : MauiApplication
{
    public MainApplication(IntPtr handle, JniHandleOwnership ownership)
        : base(handle, ownership)
    {
    }

    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}