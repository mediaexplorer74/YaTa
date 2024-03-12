// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.JamSegment
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [WebHostHidden]
  [Activatable(typeof (__IJamSegmentFactory), 1)]
  [MarshalingBehavior]
  [Version(1)]
  [Threading]
  public sealed class JamSegment : __IJamSegmentPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern JamSegment([In] JamType jamType, [In] double speed);

    public extern JamType JamType { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern double Speed { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
