// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.Internal.RawConstructions
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Masstransit.Internal
{
  [MarshalingBehavior]
  [WebHostHidden]
  [Threading]
  [Version(1)]
  [Activatable(typeof (__IRawConstructionsFactory), 1)]
  [Static(typeof (__IRawConstructionsStatics), 1)]
  public sealed class RawConstructions : __IRawConstructionsPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern RawConstructions From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern RawConstructions([In] IVectorView<RawConstruction> constructions);

    public extern IVectorView<RawConstruction> Constructions { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
