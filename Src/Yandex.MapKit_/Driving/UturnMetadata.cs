﻿// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.UturnMetadata
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [WebHostHidden]
  [MarshalingBehavior]
  [Threading]
  [Version(1)]
  [Activatable(typeof (__IUturnMetadataFactory), 1)]
  public sealed class UturnMetadata : __IUturnMetadataPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern UturnMetadata([In] double length);

    public extern double Length { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
