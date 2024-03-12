// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.RoadEvents.__IRoadEventMetadataStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.RoadEvents
{
  [Version(1)]
  [Guid(1944513815, 63567, 15224, 152, 18, 59, 50, 201, 204, 174, 139)]
  [ExclusiveTo(typeof (RoadEventMetadata))]
  [WebHostHidden]
  internal interface __IRoadEventMetadataStatics
  {
    RoadEventMetadata From([In] AnyCollection anyCollection);
  }
}
