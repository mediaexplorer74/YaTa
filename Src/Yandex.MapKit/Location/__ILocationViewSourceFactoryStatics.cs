// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Location.__ILocationViewSourceFactoryStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Location
{
  [Version(1)]
  [ExclusiveTo(typeof (LocationViewSourceFactory))]
  [WebHostHidden]
  [Guid(2782924714, 56256, 16343, 140, 63, 19, 224, 234, 148, 140, 152)]
  internal interface __ILocationViewSourceFactoryStatics
  {
    LocationViewSource CreateLocationViewSource([In] LocationManager locationManager);
  }
}
