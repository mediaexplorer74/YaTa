// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.DrivingSummaries
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [Static(typeof (__IDrivingSummariesStatics), 1)]
  [Threading]
  [Activatable(typeof (__IDrivingSummariesFactory), 1)]
  [MarshalingBehavior]
  [WebHostHidden]
  [Version(1)]
  public sealed class DrivingSummaries : __IDrivingSummariesPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern DrivingSummaries From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern DrivingSummaries([In] IVectorView<Summary> summaries);

    public extern IVectorView<Summary> Summaries { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
