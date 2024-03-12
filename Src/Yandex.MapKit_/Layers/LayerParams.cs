// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Layers.LayerParams
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Layers
{
  [MarshalingBehavior]
  [WebHostHidden]
  [Threading]
  [Version(1)]
  [Activatable(typeof (__ILayerParamsFactory), 1)]
  [Static(typeof (__ILayerParamsStatics), 1)]
  public sealed class LayerParams : __ILayerParamsPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern LayerParams From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern LayerParams([In] IMapView<string, string> @params);

    public extern IMapView<string, string> Params { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
