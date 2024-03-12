// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.__IRouteMetadataStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [Guid(2471827420, 45374, 14468, 136, 99, 147, 217, 64, 221, 174, 138)]
  [WebHostHidden]
  [Version(1)]
  [ExclusiveTo(typeof (RouteMetadata))]
  internal interface __IRouteMetadataStatics
  {
    RouteMetadata From([In] AnyCollection anyCollection);
  }
}
