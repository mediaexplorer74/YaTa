// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.__IAttributionFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit
{
  [Guid(3055060483, 53746, 13715, 143, 81, 105, 215, 14, 219, 97, 24)]
  [Version(1)]
  [ExclusiveTo(typeof (Attribution))]
  [WebHostHidden]
  internal interface __IAttributionFactory
  {
    [Overload("CreateInstance1")]
    Attribution CreateInstance([In] AttributionAuthor author, [In] AttributionLink link);
  }
}
