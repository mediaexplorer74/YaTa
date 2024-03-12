// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.Internal.__IRawWalkFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit.Internal
{
  [Guid(282642094, 49013, 13733, 178, 169, 8, 172, 178, 12, 44, 141)]
  [ExclusiveTo(typeof (RawWalk))]
  [WebHostHidden]
  [Version(1)]
  internal interface __IRawWalkFactory
  {
    [Overload("CreateInstance1")]
    RawWalk CreateInstance([In] RawConstructions constructions, [In] SpotsContainer spots);
  }
}
