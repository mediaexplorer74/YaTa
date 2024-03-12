// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__IRouteStopMetadataFactory
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
  [Guid(1285257197, 56429, 15369, 170, 94, 251, 188, 146, 45, 45, 74)]
  [ExclusiveTo(typeof (RouteStopMetadata))]
  internal interface __IRouteStopMetadataFactory
  {
    [Overload("CreateInstance1")]
    RouteStopMetadata CreateInstance([In] Stop stop);
  }
}
