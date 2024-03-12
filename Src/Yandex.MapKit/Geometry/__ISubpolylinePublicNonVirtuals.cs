// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.__ISubpolylinePublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Geometry
{
  [Guid(1868296683, 45931, 14330, 139, 120, 203, 224, 97, 178, 13, 196)]
  [ExclusiveTo(typeof (Subpolyline))]
  [Version(1)]
  [WebHostHidden]
  internal interface __ISubpolylinePublicNonVirtuals
  {
    PolylinePosition Begin { get; }

    PolylinePosition End { get; }
  }
}
