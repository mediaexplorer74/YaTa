// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__IStopMetadataFactory
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
  [Version(1)]
  [Guid(1169218602, 40723, 15083, 177, 204, 145, 218, 240, 239, 111, 109)]
  [ExclusiveTo(typeof (StopMetadata))]
  internal interface __IStopMetadataFactory
  {
    [Overload("CreateInstance1")]
    StopMetadata CreateInstance([In] Stop stop, [In] IVectorView<LineAtStop> linesAtStop);
  }
}
