﻿using System;
using Avalonia.Markup.Xaml;

namespace HanumanInstitute.MediaPlayer.Avalonia;

/// <summary>
/// Allows binding int value for command parameters using syntax {ui:Int32 5}
/// </summary>
public sealed class Int32Extension : MarkupExtension
{
    public Int32Extension(int value) { Value = value; }
    public int Value { get; set; }
    public override object ProvideValue(IServiceProvider sp) { return Value; }
};