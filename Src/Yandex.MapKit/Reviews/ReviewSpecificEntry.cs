// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Reviews.ReviewSpecificEntry
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Reviews
{
  [Threading]
  [Version(1)]
  [MarshalingBehavior]
  [WebHostHidden]
  [Static(typeof (__IReviewSpecificEntryStatics), 1)]
  [Activatable(typeof (__IReviewSpecificEntryFactory), 1)]
  public sealed class ReviewSpecificEntry : __IReviewSpecificEntryPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern ReviewSpecificEntry From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern ReviewSpecificEntry(
      [In] string businessId,
      [In] string descriptionText,
      [In] string snippet,
      [In] IReference<float> rating,
      [In] IReference<int> positive,
      [In] IReference<int> negative,
      [In] IReference<Vote> userVote,
      [In] IVectorView<global::Yandex.MapKit.Reviews.Tag> tag,
      [In] IReference<global::Yandex.MapKit.Reviews.Status> status);

    public extern string BusinessId { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string DescriptionText { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Snippet { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<float> Rating { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<int> Positive { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<int> Negative { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<Vote> UserVote { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<global::Yandex.MapKit.Reviews.Tag> Tag { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<global::Yandex.MapKit.Reviews.Status> Status { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
