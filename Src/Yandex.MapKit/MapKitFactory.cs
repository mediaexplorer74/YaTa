// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.MapKitFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit
{
  [Activatable(1)]
  [Threading]
  [Static(typeof (__IMapKitFactoryStatics), 1)]
  [WebHostHidden]
  [MarshalingBehavior]
  [Version(1)]
  public sealed class MapKitFactory : __IMapKitFactoryPublicNonVirtuals
  {
    public static extern global::Yandex.MapKit.MapKit Instance { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern MapKitFactory();
  }
}
