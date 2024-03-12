// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.RoadEvents.__IEntryPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.RoadEvents
{
  [Version(1)]
  [Guid(1528749044, 9181, 14463, 164, 51, 69, 198, 40, 240, 175, 170)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Entry))]
  internal interface __IEntryPublicNonVirtuals
  {
    global::Yandex.MapKit.Atom.Entry AtomEntry { get; }

    TextEntry Content { get; }
  }
}
