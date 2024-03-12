// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.__IFlagsPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [ExclusiveTo(typeof (Flags))]
  [WebHostHidden]
  [Version(1)]
  [Guid(3626307838, 3802, 12547, 128, 20, 135, 37, 223, 27, 45, 159)]
  internal interface __IFlagsPublicNonVirtuals
  {
    bool Blocked { get; }

    bool HasFerries { get; }

    bool HasTolls { get; }

    bool GuidanceForbidden { get; }

    bool CrossesBorders { get; }

    bool RequiresAccessPass { get; }

    bool ForParking { get; }
  }
}
