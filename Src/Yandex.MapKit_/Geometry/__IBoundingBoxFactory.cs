// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.__IBoundingBoxFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Geometry
{
  [Version(1)]
  [WebHostHidden]
  [Guid(3517045067, 7660, 14880, 179, 170, 199, 80, 35, 186, 147, 191)]
  [ExclusiveTo(typeof (BoundingBox))]
  internal interface __IBoundingBoxFactory
  {
    [Overload("CreateInstance1")]
    BoundingBox CreateInstance([In] Point southWest, [In] Point northEast);
  }
}
