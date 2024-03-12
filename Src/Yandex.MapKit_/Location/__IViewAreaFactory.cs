// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Location.__IViewAreaFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Location
{
  [ExclusiveTo(typeof (ViewArea))]
  [Guid(2029641968, 56004, 12577, 144, 78, 166, 130, 52, 116, 7, 164)]
  [WebHostHidden]
  [Version(1)]
  internal interface __IViewAreaFactory
  {
    [Overload("CreateInstance1")]
    ViewArea CreateInstance([In] double lengthwise, [In] double transverse);
  }
}
