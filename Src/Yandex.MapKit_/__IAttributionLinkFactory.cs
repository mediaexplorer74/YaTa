// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.__IAttributionLinkFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit
{
  [Version(1)]
  [ExclusiveTo(typeof (AttributionLink))]
  [Guid(4270066858, 25014, 15080, 150, 31, 12, 15, 149, 165, 169, 232)]
  [WebHostHidden]
  internal interface __IAttributionLinkFactory
  {
    [Overload("CreateInstance1")]
    AttributionLink CreateInstance([In] string href);
  }
}
