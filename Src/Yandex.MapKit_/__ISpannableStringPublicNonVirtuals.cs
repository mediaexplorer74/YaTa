// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.__ISpannableStringPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit
{
  [ExclusiveTo(typeof (SpannableString))]
  [WebHostHidden]
  [Version(1)]
  [Guid(3708935827, 36567, 12884, 137, 68, 33, 253, 31, 14, 6, 125)]
  internal interface __ISpannableStringPublicNonVirtuals
  {
    string Text { get; }

    IVectorView<SpannableStringSpan> Spans { get; }
  }
}
