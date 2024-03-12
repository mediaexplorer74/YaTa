// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IHouseFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Version(1)]
  [Guid(3972895824, 48111, 15039, 140, 226, 150, 178, 241, 162, 97, 195)]
  [ExclusiveTo(typeof (House))]
  [WebHostHidden]
  internal interface __IHouseFactory
  {
    [Overload("CreateInstance1")]
    House CreateInstance([In] string name, [In] Point position);
  }
}
