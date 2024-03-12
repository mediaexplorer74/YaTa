// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__ILineAtStopFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Guid(265378448, 50343, 15275, 176, 84, 99, 210, 77, 200, 55, 242)]
  [Version(1)]
  [WebHostHidden]
  [ExclusiveTo(typeof (LineAtStop))]
  internal interface __ILineAtStopFactory
  {
    [Overload("CreateInstance1")]
    LineAtStop CreateInstance([In] Line line, [In] IVectorView<ThreadAtStop> threadsAtStop);
  }
}
