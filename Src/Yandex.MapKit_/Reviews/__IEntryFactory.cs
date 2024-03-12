// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Reviews.__IEntryFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Reviews
{
  [ExclusiveTo(typeof (Entry))]
  [Guid(1907024640, 56802, 15178, 165, 64, 90, 45, 36, 113, 159, 199)]
  [WebHostHidden]
  [Version(1)]
  internal interface __IEntryFactory
  {
    [Overload("CreateInstance1")]
    Entry CreateInstance([In] global::Yandex.MapKit.Atom.Entry atomEntry, [In] ReviewSpecificEntry content);
  }
}
