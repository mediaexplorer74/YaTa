// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.__IRouteMetadataFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [ExclusiveTo(typeof (RouteMetadata))]
  [WebHostHidden]
  [Guid(3672248476, 16679, 15862, 130, 85, 99, 6, 186, 134, 41, 192)]
  [Version(1)]
  internal interface __IRouteMetadataFactory
  {
    [Overload("CreateInstance1")]
    RouteMetadata CreateInstance([In] Weight weight, [In] Flags flags, [In] byte[] descriptor, [In] byte[] traits);
  }
}
