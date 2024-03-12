// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Layers.__ILayerOptionsFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Layers
{
  [Version(1)]
  [ExclusiveTo(typeof (LayerOptions))]
  [WebHostHidden]
  [Guid(1992468070, 17934, 15182, 166, 240, 252, 85, 35, 122, 75, 15)]
  internal interface __ILayerOptionsFactory
  {
    [Overload("CreateInstance1")]
    LayerOptions CreateInstance(
      [In] bool active,
      [In] bool nightModeAvailable,
      [In] bool cacheable,
      [In] string version_,
      [In] bool animateOnActivation);
  }
}
