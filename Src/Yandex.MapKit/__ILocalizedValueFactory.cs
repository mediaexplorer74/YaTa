// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.__ILocalizedValueFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit
{
  [WebHostHidden]
  [ExclusiveTo(typeof (LocalizedValue))]
  [Version(1)]
  [Guid(3324278223, 35625, 14591, 181, 151, 106, 253, 133, 241, 138, 86)]
  internal interface __ILocalizedValueFactory
  {
    [Overload("CreateInstance1")]
    LocalizedValue CreateInstance([In] double value, [In] string text);
  }
}
