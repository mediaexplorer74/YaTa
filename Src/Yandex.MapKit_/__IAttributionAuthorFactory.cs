// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.__IAttributionAuthorFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit
{
  [WebHostHidden]
  [Version(1)]
  [ExclusiveTo(typeof (AttributionAuthor))]
  [Guid(1037977162, 59571, 12387, 156, 18, 99, 13, 246, 196, 229, 239)]
  internal interface __IAttributionAuthorFactory
  {
    [Overload("CreateInstance1")]
    AttributionAuthor CreateInstance([In] string name, [In] string uri, [In] string email);
  }
}
