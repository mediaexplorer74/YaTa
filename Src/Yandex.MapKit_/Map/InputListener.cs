// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Map.InputListener
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Map
{
  [Guid(3840699942, 6586, 12602, 182, 56, 183, 138, 68, 247, 118, 156)]
  [WebHostHidden]
  [Version(1)]
  public interface InputListener
  {
    void OnMapTap([In] global::Yandex.MapKit.Map.Map map, [In] Point point);

    void OnMapLongTap([In] global::Yandex.MapKit.Map.Map map, [In] Point point);
  }
}
