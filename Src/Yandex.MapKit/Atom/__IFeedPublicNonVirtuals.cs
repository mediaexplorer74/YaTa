// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Atom.__IFeedPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Atom
{
  [Guid(3002646337, 46937, 13779, 163, 145, 137, 239, 131, 179, 9, 204)]
  [Version(1)]
  [ExclusiveTo(typeof (Feed))]
  [WebHostHidden]
  internal interface __IFeedPublicNonVirtuals
  {
    string Nextpage { get; }

    IVectorView<Link> Links { get; }
  }
}
