// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.Transport
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [WebHostHidden]
  [Activatable(typeof (__ITransportFactory), 1)]
  [Static(typeof (__ITransportStatics), 1)]
  [Threading]
  [Version(1)]
  [MarshalingBehavior]
  public sealed class Transport : __ITransportPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern Transport From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Transport([In] Line line, [In] IVectorView<TransportTransportThread> threads);

    public extern Line Line { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<TransportTransportThread> Threads { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
