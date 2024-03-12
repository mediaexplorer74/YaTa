// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.__IVersionFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit
{
  [Version(1)]
  [WebHostHidden]
  [Guid(3403120747, 35008, 13349, 173, 251, 10, 247, 62, 168, 159, 119)]
  [ExclusiveTo(typeof (Version))]
  internal interface __IVersionFactory
  {
    [Overload("CreateInstance1")]
    Version CreateInstance([In] string str);
  }
}
