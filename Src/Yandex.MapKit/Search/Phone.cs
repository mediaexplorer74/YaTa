// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.Phone
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
  [Activatable(typeof (__IPhoneFactory), 1)]
  [WebHostHidden]
  [Version(1)]
  [Threading]
  [MarshalingBehavior]
  public sealed class Phone : __IPhonePublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Phone(
      [In] PhoneType type,
      [In] string formattedNumber,
      [In] string info,
      [In] IReference<uint> country,
      [In] IReference<uint> prefix,
      [In] IReference<uint> ext,
      [In] uint number);

    public extern PhoneType Type { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string FormattedNumber { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Info { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<uint> Country { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<uint> Prefix { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<uint> Ext { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern uint Number { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
