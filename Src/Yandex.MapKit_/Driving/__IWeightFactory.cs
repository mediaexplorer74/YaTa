// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.__IWeightFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [WebHostHidden]
  [Guid(185787095, 5164, 15189, 161, 37, 79, 253, 30, 137, 77, 18)]
  [ExclusiveTo(typeof (Weight))]
  [Version(1)]
  internal interface __IWeightFactory
  {
    [Overload("CreateInstance1")]
    Weight CreateInstance(
      [In] LocalizedValue time,
      [In] LocalizedValue timeWithTraffic,
      [In] LocalizedValue distance);
  }
}
