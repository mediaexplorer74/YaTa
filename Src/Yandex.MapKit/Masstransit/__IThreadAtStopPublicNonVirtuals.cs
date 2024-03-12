// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__IThreadAtStopPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [ExclusiveTo(typeof (ThreadAtStop))]
  [Guid(2268173181, 36141, 14217, 187, 193, 168, 184, 246, 138, 142, 16)]
  [WebHostHidden]
  [Version(1)]
  internal interface __IThreadAtStopPublicNonVirtuals
  {
    Thread Thread { get; }

    bool NoBoarding { get; }

    bool NoDropOff { get; }

    BriefSchedule BriefSchedule { get; }
  }
}
