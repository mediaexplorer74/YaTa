// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.UserLocation.UserLocationAnchorChanged
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;
using Yandex.MapKit.Layers;

#nullable disable
namespace Yandex.MapKit.UserLocation
{
  [Version(1)]
  [WebHostHidden]
  [Guid(1005975181, 29693, 15456, 175, 198, 235, 13, 54, 243, 97, 104)]
  public interface UserLocationAnchorChanged : ObjectEvent
  {
    UserLocationAnchorType AnchorType { get; }
  }
}
