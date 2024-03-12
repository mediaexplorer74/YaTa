// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.BusinessPhotoObjectMetadata
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Static(typeof (__IBusinessPhotoObjectMetadataStatics), 1)]
  [MarshalingBehavior]
  [WebHostHidden]
  [Activatable(typeof (__IBusinessPhotoObjectMetadataFactory), 1)]
  [Threading]
  [Version(1)]
  public sealed class BusinessPhotoObjectMetadata : __IBusinessPhotoObjectMetadataPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern BusinessPhotoObjectMetadata From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern BusinessPhotoObjectMetadata(
      [In] uint count,
      [In] IVectorView<BusinessPhotoObjectMetadataPhoto> photos);

    public extern uint Count { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<BusinessPhotoObjectMetadataPhoto> Photos { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
