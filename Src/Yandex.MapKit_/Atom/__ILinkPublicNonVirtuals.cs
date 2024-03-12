// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Atom.__ILinkPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Atom
{
  [WebHostHidden]
  [Version(1)]
  [Guid(2047967715, 15005, 12786, 163, 221, 224, 249, 27, 25, 48, 65)]
  [ExclusiveTo(typeof (Link))]
  internal interface __ILinkPublicNonVirtuals
  {
    string Href { get; }

    string Rel { get; }

    string Type { get; }
  }
}
