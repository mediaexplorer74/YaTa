// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.UserLocation.UserLocationLayer
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Location;
using Yandex.MapKit.Map;

#nullable disable
namespace Yandex.MapKit.UserLocation
{
  [Version(1)]
  [Guid(2278891258, 10050, 13521, 174, 98, 243, 70, 166, 97, 11, 169)]
  [WebHostHidden]
  public interface UserLocationLayer
  {
    bool Enabled { get; [param: In] set; }

    bool HeadingEnabled { get; [param: In] set; }

    void SetAnchor([In] Point anchorNormal, [In] Point anchorCourse);

    void ResetAnchor();

    bool AnchorEnabled { get; }

    bool AutoZoomEnabled { get; [param: In] set; }

    CameraPosition GetCameraPosition();

    void SetSource([In] LocationViewSource source);

    void SetTapListener([In] UserLocationTapListener tapListener);

    void SetObjectListener([In] UserLocationObjectListener objectListener);

    bool Valid { get; }
  }
}
