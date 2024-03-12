// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.FasterAlternative
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [MarshalingBehavior]
  [Version(1)]
  [Threading]
  [WebHostHidden]
  [Activatable(typeof (__IFasterAlternativeFactory), 1)]
  public sealed class FasterAlternative : __IFasterAlternativePublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern FasterAlternative([In] LocalizedValue timeDifference);

    public extern LocalizedValue TimeDifference { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
