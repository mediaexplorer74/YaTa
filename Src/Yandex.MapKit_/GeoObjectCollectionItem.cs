// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.GeoObjectCollectionItem
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit
{
  [WebHostHidden]
  [Static(typeof (__IGeoObjectCollectionItemStatics), 1)]
  [MarshalingBehavior]
  [Threading]
  [Version(1)]
  public sealed class GeoObjectCollectionItem : __IGeoObjectCollectionItemPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern GeoObjectCollectionItem FromObj([In] GeoObject obj);

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern GeoObjectCollectionItem FromCollection([In] GeoObjectCollection collection);

    public extern GeoObject Obj { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern GeoObjectCollection Collection { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
