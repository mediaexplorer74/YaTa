// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.WorkingHours
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Search
{
  [WebHostHidden]
  [Version(1)]
  [MarshalingBehavior]
  [Activatable(typeof (__IWorkingHoursFactory), 1)]
  [Threading]
  [Static(typeof (__IWorkingHoursStatics), 1)]
  public sealed class WorkingHours : __IWorkingHoursPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern WorkingHours From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern WorkingHours([In] string text, [In] IVectorView<Availability> availabilities);

    public extern string Text { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<Availability> Availabilities { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
