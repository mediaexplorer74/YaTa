// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.RequestPoint
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [MarshalingBehavior]
  [WebHostHidden]
  [Version(1)]
  [Activatable(typeof (__IRequestPointFactory), 1)]
  [Threading]
  public sealed class RequestPoint : __IRequestPointPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern RequestPoint([In] Point point, [In] RequestPointType type);

    public extern Point Point { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern RequestPointType Type { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
