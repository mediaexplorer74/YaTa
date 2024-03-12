// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.Router
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Search
{
  [MarshalingBehavior]
  [Version(1)]
  [WebHostHidden]
  [Activatable(typeof (__IRouterFactory), 1)]
  [Static(typeof (__IRouterStatics), 1)]
  [Threading]
  public sealed class Router : __IRouterPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern Router From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Router([In] IVectorView<RouterType> types);

    public extern IVectorView<RouterType> Types { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
