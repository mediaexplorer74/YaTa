// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Layers.__ILayerOptionsPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Layers
{
  [ExclusiveTo(typeof (LayerOptions))]
  [Guid(4260370434, 24481, 15553, 166, 241, 96, 75, 115, 118, 2, 18)]
  [WebHostHidden]
  [Version(1)]
  internal interface __ILayerOptionsPublicNonVirtuals
  {
    bool Active { get; [param: In] set; }

    bool NightModeAvailable { get; [param: In] set; }

    bool Cacheable { get; [param: In] set; }

    string Version_ { get; [param: In] set; }

    bool AnimateOnActivation { get; [param: In] set; }
  }
}
