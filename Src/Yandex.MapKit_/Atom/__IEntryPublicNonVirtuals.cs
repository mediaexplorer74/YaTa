// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Atom.__IEntryPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Atom
{
  [ExclusiveTo(typeof (Entry))]
  [Version(1)]
  [WebHostHidden]
  [Guid(3356040043, 51762, 15883, 189, 83, 33, 108, 242, 214, 47, 237)]
  internal interface __IEntryPublicNonVirtuals
  {
    string Id { get; }

    string UpdateTime { get; }

    Author Author { get; }

    Attribution Attribution { get; }

    IVectorView<Link> Links { get; }
  }
}
