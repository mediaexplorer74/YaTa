// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.Section
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [WebHostHidden]
  [Version(1)]
  [Activatable(typeof (__ISectionFactory), 1)]
  [Threading]
  [Static(typeof (__ISectionStatics), 1)]
  [MarshalingBehavior]
  public sealed class Section : __ISectionPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern Section From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Section([In] SectionMetadata metadata, [In] Subpolyline geometry);

    public extern SectionMetadata Metadata { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern Subpolyline Geometry { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
