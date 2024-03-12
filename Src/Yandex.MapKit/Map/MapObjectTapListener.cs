// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Map.MapObjectTapListener
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Map
{
  [Guid(86653685, 41842, 14784, 188, 198, 207, 209, 154, 111, 69, 232)]
  [WebHostHidden]
  [Version(1)]
  public interface MapObjectTapListener
  {
    bool OnMapObjectTap([In] MapObject mapObject, [In] Point point);
  }
}
