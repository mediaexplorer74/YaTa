// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.Summary
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [Threading]
  [Activatable(typeof (__ISummaryFactory), 1)]
  [MarshalingBehavior]
  [WebHostHidden]
  [Version(1)]
  public sealed class Summary : __ISummaryPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Summary([In] Weight weight, [In] Flags flags);

    public extern Weight Weight { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern Flags Flags { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
