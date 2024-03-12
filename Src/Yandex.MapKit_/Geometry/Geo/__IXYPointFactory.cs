// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.Geo.__IXYPointFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Geometry.Geo
{
  [Version(1)]
  [ExclusiveTo(typeof (XYPoint))]
  [WebHostHidden]
  [Guid(3963413977, 38238, 12622, 137, 119, 115, 128, 47, 63, 223, 15)]
  internal interface __IXYPointFactory
  {
    [Overload("CreateInstance1")]
    XYPoint CreateInstance([In] double x, [In] double y);
  }
}
