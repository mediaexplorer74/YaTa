// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Atom.__IEntryFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Atom
{
  [ExclusiveTo(typeof (Entry))]
  [Version(1)]
  [Guid(2568985189, 62992, 14553, 147, 87, 81, 27, 114, 160, 91, 95)]
  [WebHostHidden]
  internal interface __IEntryFactory
  {
    [Overload("CreateInstance1")]
    Entry CreateInstance(
      [In] string id,
      [In] string updateTime,
      [In] Author author,
      [In] Attribution attribution,
      [In] IVectorView<Link> links);
  }
}
