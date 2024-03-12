// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Coverage.Region
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Coverage
{
  [Version(1)]
  [Activatable(typeof (__IRegionFactory), 1)]
  [WebHostHidden]
  [Threading]
  [MarshalingBehavior]
  public sealed class Region : __IRegionPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Region([In] int id, [In] int zoomMin, [In] int zoomMax);

    public extern int Id { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern int ZoomMin { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern int ZoomMax { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
