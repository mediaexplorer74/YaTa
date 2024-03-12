// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.UserLocation.UserLocationIconChanged
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;
using Yandex.MapKit.Layers;

#nullable disable
namespace Yandex.MapKit.UserLocation
{
  [WebHostHidden]
  [Guid(2032145724, 61050, 15053, 154, 10, 109, 180, 104, 33, 232, 185)]
  [Version(1)]
  public interface UserLocationIconChanged : ObjectEvent
  {
    UserLocationIconType IconType { get; }
  }
}
