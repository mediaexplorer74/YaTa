﻿// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.Internal.__IRawLaneSignsPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving.Internal
{
  [Guid(4129100983, 42276, 16123, 142, 76, 215, 20, 252, 170, 154, 31)]
  [WebHostHidden]
  [Version(1)]
  [ExclusiveTo(typeof (RawLaneSigns))]
  internal interface __IRawLaneSignsPublicNonVirtuals
  {
    IVectorView<RawLaneSign> LaneSigns { get; }
  }
}
