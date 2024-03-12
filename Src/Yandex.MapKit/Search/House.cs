// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.House
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
  [Activatable(typeof (__IHouseFactory), 1)]
  [Version(1)]
  [MarshalingBehavior]
  [WebHostHidden]
  [Threading]
  public sealed class House : __IHousePublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern House([In] string name, [In] Point position);

    public extern string Name { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern Point Position { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
