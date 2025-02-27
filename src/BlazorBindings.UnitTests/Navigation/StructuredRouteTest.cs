﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using BlazorBindings.Maui.ShellNavigation;

namespace BlazorBindings.UnitTests;

public class StructuredRouteTests
{
    public class TestComponent : ComponentBase
    {
        [Parameter] public string StringParameter { get; set; }
        [Parameter] public int IntParameter { get; set; }
        public string NonParameter { get; set; }
    }

    [Test]
    public void NoParameterRouteIsBaseUri()
    {
        var uri = "/home";
        var route = new StructuredRoute(uri, typeof(TestComponent));

        Assert.AreEqual(uri, route.BaseUri);
    }

    [Test]
    public void NoParameterRouteIsOriginalUri()
    {
        var uri = "/home";
        var route = new StructuredRoute(uri, typeof(TestComponent));

        Assert.AreEqual(uri, route.OriginalUri);
    }

    [Test]
    public void OneParameterOriginalUri()
    {
        var uri = "/home/{StringParameter}";
        var route = new StructuredRoute(uri, typeof(TestComponent));

        Assert.AreEqual(uri, route.OriginalUri);
    }

    [Test]
    public void OneParameterBaseUri()
    {
        var uri = "/home/{StringParameter}";
        var route = new StructuredRoute(uri, typeof(TestComponent));

        var expected = "/home";
        Assert.AreEqual(expected, route.BaseUri);
    }

    [Test]
    public void OneParameterCount()
    {
        var uri = "/home/{StringParameter}";
        var route = new StructuredRoute(uri, typeof(TestComponent));

        var expected = 1;
        Assert.AreEqual(expected, route.ParameterCount);
    }

    [Test]
    public void OneParameterKey()
    {
        var key = "StringParameter";
        var uri = "/home/{StringParameter}";
        var route = new StructuredRoute(uri, typeof(TestComponent));

        Assert.AreEqual(key, route.ParameterKeys.FirstOrDefault());
    }
}
