// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.__IPolylinePositionFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Geometry
{
  [WebHostHidden]
  [Guid(2964125867, 33255, 14210, 189, 114, 223, 43, 72, 210, 172, 111)]
  [ExclusiveTo(typeof (PolylinePosition))]
  [Version(1)]
  internal interface __IPolylinePositionFactory
  {
    [Overload("CreateInstance1")]
    PolylinePosition CreateInstance([In] uint segmentIndex, [In] double segmentPosition);
  }
}
