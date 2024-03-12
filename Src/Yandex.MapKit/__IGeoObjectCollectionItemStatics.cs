// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.__IGeoObjectCollectionItemStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit
{
  [Version(1)]
  [WebHostHidden]
  [Guid(3676664793, 22073, 15499, 175, 191, 44, 83, 138, 217, 15, 72)]
  [ExclusiveTo(typeof (GeoObjectCollectionItem))]
  internal interface __IGeoObjectCollectionItemStatics
  {
    GeoObjectCollectionItem FromObj([In] GeoObject obj);

    GeoObjectCollectionItem FromCollection([In] GeoObjectCollection collection);
  }
}
