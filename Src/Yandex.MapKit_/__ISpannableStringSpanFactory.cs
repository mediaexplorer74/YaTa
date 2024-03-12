// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.__ISpannableStringSpanFactory
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
  [Guid(3734025992, 1214, 16121, 129, 190, 52, 53, 150, 190, 235, 248)]
  [ExclusiveTo(typeof (SpannableStringSpan))]
  internal interface __ISpannableStringSpanFactory
  {
    [Overload("CreateInstance1")]
    SpannableStringSpan CreateInstance([In] int begin, [In] int end);
  }
}
