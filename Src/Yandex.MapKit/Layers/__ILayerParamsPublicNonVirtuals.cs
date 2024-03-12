// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Layers.__ILayerParamsPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Layers
{
  [Guid(3913500963, 17859, 14385, 140, 189, 149, 245, 143, 44, 99, 30)]
  [WebHostHidden]
  [ExclusiveTo(typeof (LayerParams))]
  [Version(1)]
  internal interface __ILayerParamsPublicNonVirtuals
  {
    IMapView<string, string> Params { get; }
  }
}
