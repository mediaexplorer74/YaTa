﻿// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__IThreadPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Version(1)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Thread))]
  [Guid(3554585784, 45970, 16062, 137, 225, 42, 50, 42, 161, 78, 242)]
  internal interface __IThreadPublicNonVirtuals
  {
    string Id { get; }

    string DescriptionText { get; }

    IVectorView<Stop> EssentialStops { get; }
  }
}
