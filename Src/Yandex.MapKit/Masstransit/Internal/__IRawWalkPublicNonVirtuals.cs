// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.Internal.__IRawWalkPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit.Internal
{
  [WebHostHidden]
  [Guid(3159109971, 40456, 12320, 138, 22, 11, 88, 208, 194, 36, 102)]
  [ExclusiveTo(typeof (RawWalk))]
  [Version(1)]
  internal interface __IRawWalkPublicNonVirtuals
  {
    RawConstructions Constructions { get; }

    SpotsContainer Spots { get; }
  }
}
