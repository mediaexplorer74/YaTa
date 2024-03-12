// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.Internal.__IRawConstructionsPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit.Internal
{
  [ExclusiveTo(typeof (RawConstructions))]
  [Version(1)]
  [WebHostHidden]
  [Guid(2657387386, 40276, 15764, 129, 221, 89, 161, 20, 98, 235, 174)]
  internal interface __IRawConstructionsPublicNonVirtuals
  {
    IVectorView<RawConstruction> Constructions { get; }
  }
}
