// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.__ICircleFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Geometry
{
  [WebHostHidden]
  [ExclusiveTo(typeof (Circle))]
  [Guid(3859458395, 18976, 13273, 130, 201, 203, 182, 24, 201, 215, 215)]
  [Version(1)]
  internal interface __ICircleFactory
  {
    [Overload("CreateInstance1")]
    Circle CreateInstance([In] Point center, [In] float radius);
  }
}
