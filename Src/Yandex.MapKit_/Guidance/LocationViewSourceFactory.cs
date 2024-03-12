// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.LocationViewSourceFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Location;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [Static(typeof (__ILocationViewSourceFactoryStatics), 1)]
  [WebHostHidden]
  [Threading]
  [Activatable(1)]
  [MarshalingBehavior]
  [Version(1)]
  public sealed class LocationViewSourceFactory : __ILocationViewSourceFactoryPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern LocationViewSource CreateLocationViewSource([In] Guide guide);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern LocationViewSourceFactory();
  }
}
