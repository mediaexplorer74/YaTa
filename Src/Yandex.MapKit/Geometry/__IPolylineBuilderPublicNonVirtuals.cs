// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.__IPolylineBuilderPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Geometry
{
  [WebHostHidden]
  [Version(1)]
  [Guid(1140312169, 61027, 13164, 146, 207, 252, 101, 181, 9, 178, 159)]
  [ExclusiveTo(typeof (PolylineBuilder))]
  internal interface __IPolylineBuilderPublicNonVirtuals
  {
    [Overload("Append2")]
    void Append([In] Polyline polyline);

    [DefaultOverload]
    [Overload("Append1")]
    void Append([In] Point point);

    Polyline Build();
  }
}
