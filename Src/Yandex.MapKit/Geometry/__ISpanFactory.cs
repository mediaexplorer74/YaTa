// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.__ISpanFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Geometry
{
  [Guid(826833345, 61458, 16142, 138, 56, 161, 221, 225, 64, 46, 217)]
  [Version(1)]
  [ExclusiveTo(typeof (Span))]
  [WebHostHidden]
  internal interface __ISpanFactory
  {
    [Overload("CreateInstance1")]
    Span CreateInstance([In] double horizontalAngle, [In] double verticalAngle);
  }
}
