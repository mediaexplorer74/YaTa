// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Taxi.__IRideOptionFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Taxi
{
  [WebHostHidden]
  [Guid(2285444526, 42530, 13307, 186, 94, 117, 249, 110, 166, 235, 53)]
  [Version(1)]
  [ExclusiveTo(typeof (RideOption))]
  internal interface __IRideOptionFactory
  {
    [Overload("CreateInstance1")]
    RideOption CreateInstance([In] LocalizedValue waitingTime, [In] Money cost);
  }
}
