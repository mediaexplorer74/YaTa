// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Photos.__IEntryFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Photos
{
  [WebHostHidden]
  [Version(1)]
  [Guid(2112078684, 42478, 12612, 184, 160, 110, 125, 143, 214, 239, 8)]
  [ExclusiveTo(typeof (Entry))]
  internal interface __IEntryFactory
  {
    [Overload("CreateInstance1")]
    Entry CreateInstance([In] global::Yandex.MapKit.Atom.Entry atomEntry, [In] IVectorView<Image> images, [In] Point point);
  }
}
