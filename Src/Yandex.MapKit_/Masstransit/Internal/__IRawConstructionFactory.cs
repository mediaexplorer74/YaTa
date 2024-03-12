// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.Internal.__IRawConstructionFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit.Internal
{
  [Guid(619067169, 15499, 16259, 191, 97, 28, 56, 242, 170, 185, 161)]
  [Version(1)]
  [ExclusiveTo(typeof (RawConstruction))]
  [WebHostHidden]
  internal interface __IRawConstructionFactory
  {
    [Overload("CreateInstance1")]
    RawConstruction CreateInstance([In] PedestrianConstructionID construction_id, [In] int count);
  }
}
