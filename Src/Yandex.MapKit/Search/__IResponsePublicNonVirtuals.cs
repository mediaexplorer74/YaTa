// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IResponsePublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [ExclusiveTo(typeof (Response))]
  [WebHostHidden]
  [Guid(2303074494, 19395, 16113, 174, 35, 241, 32, 199, 209, 139, 2)]
  [Version(1)]
  internal interface __IResponsePublicNonVirtuals
  {
    SearchMetadata Metadata { get; }

    GeoObjectCollection Collection { get; }

    bool IsOffline { get; }
  }
}
