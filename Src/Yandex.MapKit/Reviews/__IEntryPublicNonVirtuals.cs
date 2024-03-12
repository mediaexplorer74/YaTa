// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Reviews.__IEntryPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Reviews
{
  [WebHostHidden]
  [ExclusiveTo(typeof (Entry))]
  [Version(1)]
  [Guid(2790427721, 50758, 15976, 185, 54, 239, 96, 166, 14, 169, 15)]
  internal interface __IEntryPublicNonVirtuals
  {
    global::Yandex.MapKit.Atom.Entry AtomEntry { get; }

    ReviewSpecificEntry Content { get; }
  }
}
