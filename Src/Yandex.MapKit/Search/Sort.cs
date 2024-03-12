// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.Sort
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [MarshalingBehavior]
  [Version(1)]
  [WebHostHidden]
  [Activatable(typeof (__ISortFactory), 1)]
  [Threading]
  public sealed class Sort : __ISortPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Sort([In] SortType type, [In] IReference<SortOrigin> origin);

    public extern SortType Type { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<SortOrigin> Origin { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
