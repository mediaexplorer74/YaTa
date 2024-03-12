// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Location.__ILocationPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Location
{
  [Version(1)]
  [WebHostHidden]
  [Guid(4186255371, 34688, 13248, 185, 113, 32, 23, 39, 171, 34, 41)]
  [ExclusiveTo(typeof (global::Yandex.MapKit.Location.Location))]
  internal interface __ILocationPublicNonVirtuals
  {
    global::Yandex.MapKit.Geometry.Point Position { get; }

    IReference<double> Accuracy { get; }

    IReference<double> Altitude { get; }

    IReference<double> AltitudeAccuracy { get; }

    IReference<double> Heading { get; }

    IReference<double> Speed { get; }

    DateTime AbsoluteTimestamp { get; }

    DateTime RelativeTimestamp { get; }
  }
}
