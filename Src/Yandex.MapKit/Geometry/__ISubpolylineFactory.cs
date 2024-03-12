// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.__ISubpolylineFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Geometry
{
  [Version(1)]
  [WebHostHidden]
  [Guid(129402673, 62227, 16069, 164, 24, 41, 134, 128, 240, 119, 161)]
  [ExclusiveTo(typeof (Subpolyline))]
  internal interface __ISubpolylineFactory
  {
    [Overload("CreateInstance1")]
    Subpolyline CreateInstance([In] PolylinePosition begin, [In] PolylinePosition end);
  }
}
