// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.__IViewAreaFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [Version(1)]
  [WebHostHidden]
  [Guid(3794218659, 60854, 12958, 158, 119, 49, 8, 130, 211, 230, 252)]
  [ExclusiveTo(typeof (ViewArea))]
  internal interface __IViewAreaFactory
  {
    [Overload("CreateInstance1")]
    ViewArea CreateInstance([In] double lengthwise, [In] double transverse);
  }
}
