// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.OnMasstransitSummaries
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Guid(34748830, 60164, 13627, 187, 115, 107, 39, 194, 170, 52, 247)]
  [Version(1)]
  [WebHostHidden]
  public delegate void OnMasstransitSummaries([In] IVectorView<RouteMetadata> routes);
}
