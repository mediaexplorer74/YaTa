// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.__IRequestPointFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [Guid(272577963, 42825, 14098, 129, 255, 242, 70, 175, 138, 140, 77)]
  [WebHostHidden]
  [Version(1)]
  [ExclusiveTo(typeof (RequestPoint))]
  internal interface __IRequestPointFactory
  {
    [Overload("CreateInstance1")]
    RequestPoint CreateInstance([In] Point point, [In] RequestPointType type);
  }
}
