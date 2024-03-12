// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IStopFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Search
{
  [ExclusiveTo(typeof (Stop))]
  [Version(1)]
  [Guid(2570213098, 43314, 14428, 142, 18, 56, 13, 187, 70, 151, 62)]
  [WebHostHidden]
  internal interface __IStopFactory
  {
    [Overload("CreateInstance1")]
    Stop CreateInstance([In] string name, [In] LocalizedValue distance, [In] StopStyle style, [In] Point point);
  }
}
