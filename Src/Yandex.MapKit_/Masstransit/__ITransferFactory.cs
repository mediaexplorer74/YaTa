// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__ITransferFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [WebHostHidden]
  [Guid(3813324402, 41069, 14929, 134, 133, 18, 251, 24, 55, 146, 31)]
  [ExclusiveTo(typeof (Transfer))]
  [Version(1)]
  internal interface __ITransferFactory
  {
    [Overload("CreateInstance1")]
    Transfer CreateInstance(
      [In] IVectorView<PedestrianConstructionID> constructions);
  }
}
