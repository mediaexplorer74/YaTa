// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.__IGeoObjectCollectionStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit
{
  [ExclusiveTo(typeof (GeoObjectCollection))]
  [Version(1)]
  [WebHostHidden]
  [Guid(1106397307, 35184, 15992, 148, 125, 29, 190, 60, 185, 199, 126)]
  internal interface __IGeoObjectCollectionStatics
  {
    GeoObjectCollection From([In] AnyCollection anyCollection);
  }
}
