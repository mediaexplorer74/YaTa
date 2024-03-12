// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.__IScreenRectFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit
{
  [WebHostHidden]
  [Version(1)]
  [ExclusiveTo(typeof (ScreenRect))]
  [Guid(3434064968, 1513, 15048, 181, 25, 115, 122, 18, 24, 129, 117)]
  internal interface __IScreenRectFactory
  {
    [Overload("CreateInstance1")]
    ScreenRect CreateInstance([In] ScreenPoint topLeft, [In] ScreenPoint bottomRight);
  }
}
