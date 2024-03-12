// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Location.LocationViewSourceFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Location
{
  [Activatable(1)]
  [Threading]
  [Static(typeof (__ILocationViewSourceFactoryStatics), 1)]
  [Version(1)]
  [MarshalingBehavior]
  [WebHostHidden]
  public sealed class LocationViewSourceFactory : __ILocationViewSourceFactoryPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern LocationViewSource CreateLocationViewSource([In] LocationManager locationManager);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern LocationViewSourceFactory();
  }
}
