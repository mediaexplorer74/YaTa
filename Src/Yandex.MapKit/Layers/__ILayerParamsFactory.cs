// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Layers.__ILayerParamsFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Layers
{
  [Version(1)]
  [WebHostHidden]
  [Guid(3839577478, 2976, 13144, 178, 128, 119, 213, 21, 227, 159, 118)]
  [ExclusiveTo(typeof (LayerParams))]
  internal interface __ILayerParamsFactory
  {
    [Overload("CreateInstance1")]
    LayerParams CreateInstance([In] IMapView<string, string> @params);
  }
}
