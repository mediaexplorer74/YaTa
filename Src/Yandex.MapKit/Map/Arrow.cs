// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Map.Arrow
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
  [Guid(83668027, 48602, 15022, 185, 9, 239, 108, 79, 255, 236, 55)]
  public interface Arrow
  {
    PolylinePosition Position { get; [param: In] set; }

    uint FillColor { get; [param: In] set; }

    float Length { get; [param: In] set; }

    bool Visible { get; [param: In] set; }

    float TriangleHeight { get; [param: In] set; }

    bool Valid { get; }
  }
}
