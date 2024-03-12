// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.Internal.RawTransfer
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
  [WebHostHidden]
  [Threading]
  [MarshalingBehavior]
  [Version(1)]
  [Activatable(typeof (__IRawTransferFactory), 1)]
  [Static(typeof (__IRawTransferStatics), 1)]
  public sealed class RawTransfer : __IRawTransferPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern RawTransfer From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern RawTransfer([In] RawConstructions constructions);

    public extern RawConstructions Constructions { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
