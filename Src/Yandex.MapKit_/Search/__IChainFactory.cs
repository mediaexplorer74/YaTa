// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IChainFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Guid(104110199, 29681, 14614, 181, 139, 86, 195, 105, 229, 58, 16)]
  [Version(1)]
  [ExclusiveTo(typeof (Chain))]
  [WebHostHidden]
  internal interface __IChainFactory
  {
    [Overload("CreateInstance1")]
    Chain CreateInstance([In] string id, [In] string name);
  }
}
