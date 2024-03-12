// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__IThreadStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Guid(3660431838, 33102, 13423, 160, 49, 116, 89, 101, 13, 69, 19)]
  [Version(1)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Thread))]
  internal interface __IThreadStatics
  {
    Thread From([In] AnyCollection anyCollection);
  }
}
