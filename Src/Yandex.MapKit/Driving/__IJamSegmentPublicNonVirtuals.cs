// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.__IJamSegmentPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [Guid(550327977, 394, 14219, 175, 46, 104, 59, 176, 225, 41, 127)]
  [Version(1)]
  [WebHostHidden]
  [ExclusiveTo(typeof (JamSegment))]
  internal interface __IJamSegmentPublicNonVirtuals
  {
    JamType JamType { get; }

    double Speed { get; }
  }
}
