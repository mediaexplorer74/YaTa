// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.Internal.RawWalk
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Masstransit.Internal
{
  [Activatable(typeof (__IRawWalkFactory), 1)]
  [MarshalingBehavior]
  [WebHostHidden]
  [Static(typeof (__IRawWalkStatics), 1)]
  [Version(1)]
  [Threading]
  public sealed class RawWalk : __IRawWalkPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern RawWalk From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern RawWalk([In] RawConstructions constructions, [In] SpotsContainer spots);

    public extern RawConstructions Constructions { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern SpotsContainer Spots { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
