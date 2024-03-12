// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Coverage.__IRegionFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Coverage
{
  [Version(1)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Region))]
  [Guid(525122093, 40830, 13590, 140, 19, 23, 244, 137, 170, 9, 133)]
  internal interface __IRegionFactory
  {
    [Overload("CreateInstance1")]
    Region CreateInstance([In] int id, [In] int zoomMin, [In] int zoomMax);
  }
}
