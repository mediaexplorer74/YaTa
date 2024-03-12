// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.StopMetadata
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
  [Activatable(typeof (__IStopMetadataFactory), 1)]
  [Static(typeof (__IStopMetadataStatics), 1)]
  [Version(1)]
  [Threading]
  [MarshalingBehavior]
  public sealed class StopMetadata : __IStopMetadataPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern StopMetadata From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern StopMetadata([In] Stop stop, [In] IVectorView<LineAtStop> linesAtStop);

    public extern Stop Stop { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<LineAtStop> LinesAtStop { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
