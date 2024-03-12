// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Map.__ICameraPositionFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Map
{
  [WebHostHidden]
  [ExclusiveTo(typeof (CameraPosition))]
  [Version(1)]
  [Guid(1392253901, 27765, 13246, 170, 250, 57, 46, 62, 217, 165, 93)]
  internal interface __ICameraPositionFactory
  {
    [Overload("CreateInstance1")]
    CameraPosition CreateInstance([In] Point target, [In] float zoom, [In] float azimuth, [In] float tilt);
  }
}
