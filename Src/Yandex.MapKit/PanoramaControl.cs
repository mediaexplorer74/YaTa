// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.PanoramaControl
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
using Yandex.MapKit.Panorama;

#nullable disable
namespace Yandex.MapKit
{
  [MarshalingBehavior]
  [WebHostHidden]
  [Version(1)]
  [Activatable(1)]
  [Threading]
  public sealed class PanoramaControl : Grid, __IPanoramaControlPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern PanoramaControl();

    public extern Player Player { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
