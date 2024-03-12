// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.__ISegmentFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Geometry
{
  [ExclusiveTo(typeof (Segment))]
  [Guid(1381351521, 36081, 13136, 157, 18, 64, 231, 63, 231, 221, 92)]
  [WebHostHidden]
  [Version(1)]
  internal interface __ISegmentFactory
  {
    [Overload("CreateInstance1")]
    Segment CreateInstance([In] Point startPoint, [In] Point endPoint);
  }
}
