// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.Internal.__IRawLaneSignPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving.Internal
{
  [Version(1)]
  [ExclusiveTo(typeof (RawLaneSign))]
  [WebHostHidden]
  [Guid(3306223716, 41977, 15385, 129, 181, 227, 64, 19, 125, 153, 239)]
  internal interface __IRawLaneSignPublicNonVirtuals
  {
    uint Position { get; }

    IVectorView<Lane> Lanes { get; }
  }
}
