// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IFacetFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [WebHostHidden]
  [ExclusiveTo(typeof (Facet))]
  [Version(1)]
  [Guid(4027556951, 49555, 16174, 131, 161, 116, 67, 92, 62, 156, 217)]
  internal interface __IFacetFactory
  {
    [Overload("CreateInstance1")]
    Facet CreateInstance([In] string facetClass, [In] string name, [In] uint ratings, [In] IReference<float> score);
  }
}
