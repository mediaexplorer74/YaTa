// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.__ILocationViewSourceFactoryStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Location;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [WebHostHidden]
  [Version(1)]
  [ExclusiveTo(typeof (LocationViewSourceFactory))]
  [Guid(2673924094, 47288, 14152, 172, 90, 219, 130, 121, 124, 221, 150)]
  internal interface __ILocationViewSourceFactoryStatics
  {
    LocationViewSource CreateLocationViewSource([In] Guide guide);
  }
}
