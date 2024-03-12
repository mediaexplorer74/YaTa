// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.Flags
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [Activatable(typeof (__IFlagsFactory), 1)]
  [Threading]
  [WebHostHidden]
  [Version(1)]
  [MarshalingBehavior]
  public sealed class Flags : __IFlagsPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Flags(
      [In] bool blocked,
      [In] bool hasFerries,
      [In] bool hasTolls,
      [In] bool guidanceForbidden,
      [In] bool crossesBorders,
      [In] bool requiresAccessPass,
      [In] bool forParking);

    public extern bool Blocked { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern bool HasFerries { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern bool HasTolls { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern bool GuidanceForbidden { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern bool CrossesBorders { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern bool RequiresAccessPass { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern bool ForParking { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
