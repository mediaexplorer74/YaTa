// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.__ISpannableStringFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit
{
  [Guid(2724245731, 50565, 13618, 186, 42, 51, 129, 45, 206, 112, 222)]
  [ExclusiveTo(typeof (SpannableString))]
  [WebHostHidden]
  [Version(1)]
  internal interface __ISpannableStringFactory
  {
    [Overload("CreateInstance1")]
    SpannableString CreateInstance([In] string text, [In] IVectorView<SpannableStringSpan> spans);
  }
}
