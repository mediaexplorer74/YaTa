// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.__IPointFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Geometry
{
  [ExclusiveTo(typeof (Point))]
  [WebHostHidden]
  [Version(1)]
  [Guid(1343109757, 1986, 13076, 146, 127, 198, 136, 105, 63, 102, 92)]
  internal interface __IPointFactory
  {
    [Overload("CreateInstance1")]
    Point CreateInstance([In] double latitude, [In] double longitude);
  }
}
