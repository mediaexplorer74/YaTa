﻿// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.__IAnimationFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit
{
  [WebHostHidden]
  [Guid(4042130465, 64660, 14626, 130, 11, 80, 106, 201, 72, 244, 195)]
  [Version(1)]
  [ExclusiveTo(typeof (Animation))]
  internal interface __IAnimationFactory
  {
    [Overload("CreateInstance1")]
    Animation CreateInstance([In] AnimationType type, [In] float duration);
  }
}
