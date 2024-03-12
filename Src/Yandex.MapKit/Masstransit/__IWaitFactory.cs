// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__IWaitFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Guid(362201051, 21281, 15626, 146, 50, 80, 135, 46, 223, 44, 52)]
  [ExclusiveTo(typeof (Wait))]
  [Version(1)]
  [WebHostHidden]
  internal interface __IWaitFactory
  {
    [Overload("CreateInstance1")]
    Wait CreateInstance([In] uint dummy);
  }
}
