// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.__II18nTimeFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit
{
  [Version(1)]
  [ExclusiveTo(typeof (I18nTime))]
  [WebHostHidden]
  [Guid(4270819686, 52771, 13576, 144, 123, 217, 180, 45, 142, 66, 234)]
  internal interface __II18nTimeFactory
  {
    [Overload("CreateInstance1")]
    I18nTime CreateInstance([In] long value, [In] int tzOffset, [In] string text);
  }
}
