﻿// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__IWeightFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [WebHostHidden]
  [Version(1)]
  [ExclusiveTo(typeof (Weight))]
  [Guid(1812016266, 45759, 15925, 167, 137, 110, 186, 141, 188, 96, 32)]
  internal interface __IWeightFactory
  {
    [Overload("CreateInstance1")]
    Weight CreateInstance([In] LocalizedValue time, [In] LocalizedValue walkingDistance, [In] uint transfersCount);
  }
}
