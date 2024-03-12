// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__ILineStyleFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [WebHostHidden]
  [Version(1)]
  [Guid(3210734761, 8384, 13491, 176, 7, 149, 18, 101, 119, 60, 36)]
  [ExclusiveTo(typeof (LineStyle))]
  internal interface __ILineStyleFactory
  {
    [Overload("CreateInstance1")]
    LineStyle CreateInstance([In] IReference<uint> color);
  }
}
