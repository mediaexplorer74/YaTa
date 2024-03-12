// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__ILineFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Version(1)]
  [ExclusiveTo(typeof (Line))]
  [WebHostHidden]
  [Guid(2763366450, 61745, 12341, 140, 116, 71, 82, 181, 123, 183, 39)]
  internal interface __ILineFactory
  {
    [Overload("CreateInstance1")]
    Line CreateInstance([In] string id, [In] string name, [In] IVectorView<Type> vehicleTypes, [In] LineStyle style);
  }
}
