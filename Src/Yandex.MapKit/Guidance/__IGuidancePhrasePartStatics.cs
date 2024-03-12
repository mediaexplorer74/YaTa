// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.__IGuidancePhrasePartStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [WebHostHidden]
  [ExclusiveTo(typeof (GuidancePhrasePart))]
  [Version(1)]
  [Guid(4225541904, 43303, 13645, 184, 124, 28, 47, 202, 42, 216, 210)]
  internal interface __IGuidancePhrasePartStatics
  {
    GuidancePhrasePart FromAction([In] GuidancePhraseDrivingAction action);

    GuidancePhrasePart FromEvent([In] GuidancePhraseRoadEvent @event);
  }
}
