// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Location.LocationManagerUtils
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Location
{
  [Threading]
  [Version(1)]
  [WebHostHidden]
  [Activatable(1)]
  [MarshalingBehavior]
  [Static(typeof (__ILocationManagerUtilsStatics), 1)]
  public sealed class LocationManagerUtils : __ILocationManagerUtilsPublicNonVirtuals
  {
    public static extern global::Yandex.MapKit.Location.Location LastKnownLocation { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern LocationManagerUtils();
  }
}
