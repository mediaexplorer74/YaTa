// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.Stop
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Threading]
  [Version(1)]
  [WebHostHidden]
  [Activatable(typeof (__IStopFactory), 1)]
  [MarshalingBehavior]
  public sealed class Stop : __IStopPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Stop([In] string name, [In] LocalizedValue distance, [In] StopStyle style, [In] Point point);

    public extern string Name { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern LocalizedValue Distance { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern StopStyle Style { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern Point Point { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
