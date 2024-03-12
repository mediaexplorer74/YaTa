// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Atom.__ILinkFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Atom
{
  [Version(1)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Link))]
  [Guid(4222831780, 8915, 14068, 167, 62, 65, 154, 233, 171, 106, 227)]
  internal interface __ILinkFactory
  {
    [Overload("CreateInstance1")]
    Link CreateInstance([In] string href, [In] string rel, [In] string type);
  }
}
