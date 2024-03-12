// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IRouterPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [WebHostHidden]
  [ExclusiveTo(typeof (Router))]
  [Guid(154570266, 55979, 14152, 161, 124, 3, 148, 142, 80, 23, 4)]
  [Version(1)]
  internal interface __IRouterPublicNonVirtuals
  {
    IVectorView<RouterType> Types { get; }
  }
}
