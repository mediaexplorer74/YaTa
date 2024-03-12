// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.UserLocation.UserLocationObjectListener
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Layers;

#nullable disable
namespace Yandex.MapKit.UserLocation
{
  [Guid(1174733765, 2689, 15619, 159, 48, 41, 96, 149, 132, 86, 122)]
  [Version(1)]
  [WebHostHidden]
  public interface UserLocationObjectListener
  {
    void OnObjectAdded([In] UserLocationView view);

    void OnObjectRemoved([In] UserLocationView view);

    void OnObjectUpdated([In] UserLocationView view, [In] ObjectEvent @event);
  }
}
