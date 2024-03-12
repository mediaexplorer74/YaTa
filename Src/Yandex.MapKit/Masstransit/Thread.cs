// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.Thread
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
  [Static(typeof (__IThreadStatics), 1)]
  [Version(1)]
  [WebHostHidden]
  [Activatable(typeof (__IThreadFactory), 1)]
  [MarshalingBehavior]
  [Threading]
  public sealed class Thread : __IThreadPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern Thread From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Thread([In] string id, [In] string descriptionText, [In] IVectorView<Stop> essentialStops);

    public extern string Id { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string DescriptionText { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<Stop> EssentialStops { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
