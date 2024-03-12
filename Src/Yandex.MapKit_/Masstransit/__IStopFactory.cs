// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__IStopFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [WebHostHidden]
  [Guid(2505804892, 29279, 12395, 132, 197, 76, 194, 154, 177, 32, 17)]
  [ExclusiveTo(typeof (Stop))]
  [Version(1)]
  internal interface __IStopFactory
  {
    [Overload("CreateInstance1")]
    Stop CreateInstance([In] string id, [In] string name);
  }
}
