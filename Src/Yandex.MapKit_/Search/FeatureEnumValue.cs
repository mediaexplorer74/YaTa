﻿// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.FeatureEnumValue
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [MarshalingBehavior]
  [Threading]
  [Activatable(typeof (__IFeatureEnumValueFactory), 1)]
  [WebHostHidden]
  [Version(1)]
  public sealed class FeatureEnumValue : __IFeatureEnumValuePublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern FeatureEnumValue([In] string id, [In] string name);

    public extern string Id { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Name { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
