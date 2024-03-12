// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.BusinessPhotoObjectMetadataPhoto
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [MarshalingBehavior]
  [Activatable(typeof (__IBusinessPhotoObjectMetadataPhotoFactory), 1)]
  [Threading]
  [Version(1)]
  [WebHostHidden]
  public sealed class BusinessPhotoObjectMetadataPhoto : 
    __IBusinessPhotoObjectMetadataPhotoPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern BusinessPhotoObjectMetadataPhoto([In] string id);

    public extern string Id { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
