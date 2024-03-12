// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Map.MapObjectDragListener
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Map
{
  [Version(1)]
  [WebHostHidden]
  [Guid(1177465499, 60144, 15879, 187, 160, 193, 142, 200, 87, 14, 191)]
  public interface MapObjectDragListener
  {
    void OnMapObjectDragStart([In] MapObject mapObject);

    void OnMapObjectDrag([In] MapObject mapObject, [In] Point point);

    void OnMapObjectDragEnd([In] MapObject mapObject);
  }
}
