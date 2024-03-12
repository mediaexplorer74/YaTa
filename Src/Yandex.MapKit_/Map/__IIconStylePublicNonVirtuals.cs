// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Map.__IIconStylePublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Map
{
  [Guid(1401875426, 53063, 14674, 173, 86, 164, 250, 190, 72, 224, 114)]
  [ExclusiveTo(typeof (IconStyle))]
  [Version(1)]
  [WebHostHidden]
  internal interface __IIconStylePublicNonVirtuals
  {
    IReference<Point> Anchor { get; [param: In] set; }

    IReference<global::Yandex.MapKit.Map.RotationType> RotationType { get; [param: In] set; }

    IReference<float> ZIndex { get; [param: In] set; }

    IReference<bool> Flat { get; [param: In] set; }

    IReference<bool> Visible { get; [param: In] set; }
  }
}
