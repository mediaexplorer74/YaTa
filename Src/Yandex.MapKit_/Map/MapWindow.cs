// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Map.MapWindow
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
  [Guid(3005547973, 766, 15670, 142, 97, 168, 97, 95, 122, 104, 36)]
  public interface MapWindow
  {
    global::Yandex.MapKit.Map.Map Map { get; }

    ScreenPoint WorldToScreen([In] Point worldPoint);

    Point ScreenToWorld([In] ScreenPoint screenPoint);

    ScreenRect FocusRect { get; [param: In] set; }

    VisibleRegion FocusRegion { get; }

    bool Valid { get; }
  }
}
