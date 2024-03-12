// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.__IActionMetadataFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [Version(1)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ActionMetadata))]
  [Guid(3906201936, 61161, 14800, 143, 116, 103, 247, 63, 30, 26, 91)]
  internal interface __IActionMetadataFactory
  {
    [Overload("CreateInstance1")]
    ActionMetadata CreateInstance(
      [In] UturnMetadata uturnMetadata,
      [In] LeaveRoundaboutMetadata leaveRoundaboutMetadada);
  }
}
