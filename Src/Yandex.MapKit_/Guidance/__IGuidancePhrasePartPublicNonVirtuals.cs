// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.__IGuidancePhrasePartPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [WebHostHidden]
  [Version(1)]
  [ExclusiveTo(typeof (GuidancePhrasePart))]
  [Guid(3579965088, 28173, 16333, 162, 59, 196, 182, 206, 152, 13, 238)]
  internal interface __IGuidancePhrasePartPublicNonVirtuals
  {
    GuidancePhraseDrivingAction Action { get; }

    GuidancePhraseRoadEvent Event { get; }
  }
}
