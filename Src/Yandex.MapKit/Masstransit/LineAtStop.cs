// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.LineAtStop
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
  [Activatable(typeof (__ILineAtStopFactory), 1)]
  [Version(1)]
  [Static(typeof (__ILineAtStopStatics), 1)]
  [Threading]
  [MarshalingBehavior]
  public sealed class LineAtStop : __ILineAtStopPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern LineAtStop From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern LineAtStop([In] Line line, [In] IVectorView<ThreadAtStop> threadsAtStop);

    public extern Line Line { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<ThreadAtStop> ThreadsAtStop { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
