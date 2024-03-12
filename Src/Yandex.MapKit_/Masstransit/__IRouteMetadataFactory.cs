// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__IRouteMetadataFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Guid(3465768140, 49952, 14454, 130, 57, 18, 144, 148, 250, 58, 180)]
  [Version(1)]
  [WebHostHidden]
  [ExclusiveTo(typeof (RouteMetadata))]
  internal interface __IRouteMetadataFactory
  {
    [Overload("CreateInstance1")]
    RouteMetadata CreateInstance([In] Weight weight);
  }
}
