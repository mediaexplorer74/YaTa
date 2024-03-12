// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Taxi.__IRideInfoPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Taxi
{
  [ExclusiveTo(typeof (RideInfo))]
  [Version(1)]
  [WebHostHidden]
  [Guid(1410841801, 59620, 15259, 160, 253, 221, 35, 60, 146, 136, 165)]
  internal interface __IRideInfoPublicNonVirtuals
  {
    IVectorView<RideOption> RideOptions { get; }
  }
}
