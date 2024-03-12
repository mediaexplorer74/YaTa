// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.__ISectionFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [ExclusiveTo(typeof (Section))]
  [Version(1)]
  [Guid(2199471592, 9422, 15972, 160, 100, 38, 126, 104, 21, 36, 102)]
  [WebHostHidden]
  internal interface __ISectionFactory
  {
    [Overload("CreateInstance1")]
    Section CreateInstance([In] SectionMetadata metadata, [In] Subpolyline geometry);
  }
}
