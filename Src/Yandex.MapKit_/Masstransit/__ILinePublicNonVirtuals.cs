// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__ILinePublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [ExclusiveTo(typeof (Line))]
  [Version(1)]
  [WebHostHidden]
  [Guid(141614667, 12509, 12497, 183, 77, 94, 7, 250, 23, 101, 185)]
  internal interface __ILinePublicNonVirtuals
  {
    string Id { get; }

    string Name { get; }

    IVectorView<Type> VehicleTypes { get; }

    LineStyle Style { get; }
  }
}
