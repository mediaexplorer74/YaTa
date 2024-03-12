// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Map.PlacemarkMapObject
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;
using Yandex.Runtime.Image;

#nullable disable
namespace Yandex.MapKit.Map
{
  [WebHostHidden]
  [Guid(1337805532, 33373, 13573, 169, 142, 104, 160, 193, 60, 136, 100)]
  [Version(1)]
  public interface PlacemarkMapObject : MapObject
  {
    Point Geometry { get; [param: In] set; }

    float Direction { get; [param: In] set; }

    [Overload("SetIcon1")]
    void SetIcon([In] ImageProvider image, [In] IconStyle style);

    [Overload("SetIcon2")]
    void SetIcon([In] ImageProvider image);

    CompositeIcon UseCompositeIcon();
  }
}
