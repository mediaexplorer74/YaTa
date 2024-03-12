// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.MapControl
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
using Yandex.MapKit.Map;

#nullable disable
namespace Yandex.MapKit
{
  [Threading]
  [MarshalingBehavior]
  [WebHostHidden]
  [Version(1)]
  [Activatable(1)]
  public sealed class MapControl : Grid, __IMapControlPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern MapControl();

    public extern MapWindow MapWindow { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
