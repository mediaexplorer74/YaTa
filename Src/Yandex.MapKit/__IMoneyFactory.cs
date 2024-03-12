// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.__IMoneyFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit
{
  [ExclusiveTo(typeof (Money))]
  [WebHostHidden]
  [Version(1)]
  [Guid(3046134478, 5968, 14000, 159, 189, 196, 155, 148, 96, 21, 30)]
  internal interface __IMoneyFactory
  {
    [Overload("CreateInstance1")]
    Money CreateInstance([In] double value, [In] string text, [In] string currency);
  }
}
