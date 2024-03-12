// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.ResourceUrlProvider.__IDefaultUrlProviderPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.ResourceUrlProvider
{
  [ExclusiveTo(typeof (DefaultUrlProvider))]
  [Version(1)]
  [WebHostHidden]
  [Guid(812254251, 28262, 15669, 157, 6, 247, 18, 163, 3, 47, 129)]
  internal interface __IDefaultUrlProviderPublicNonVirtuals
  {
    void SetUrlBase([In] string urlBase);
  }
}
