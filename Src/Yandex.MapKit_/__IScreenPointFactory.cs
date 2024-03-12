// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.__IScreenPointFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit
{
  [ExclusiveTo(typeof (ScreenPoint))]
  [WebHostHidden]
  [Guid(1828761487, 52528, 14325, 167, 79, 8, 6, 49, 108, 164, 102)]
  [Version(1)]
  internal interface __IScreenPointFactory
  {
    [Overload("CreateInstance1")]
    ScreenPoint CreateInstance([In] float x, [In] float y);
  }
}
