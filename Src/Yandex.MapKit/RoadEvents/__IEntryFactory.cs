// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.RoadEvents.__IEntryFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.RoadEvents
{
  [ExclusiveTo(typeof (Entry))]
  [Guid(2170543699, 13121, 13573, 134, 50, 27, 163, 145, 86, 187, 153)]
  [WebHostHidden]
  [Version(1)]
  internal interface __IEntryFactory
  {
    [Overload("CreateInstance1")]
    Entry CreateInstance([In] global::Yandex.MapKit.Atom.Entry atomEntry, [In] TextEntry content);
  }
}
