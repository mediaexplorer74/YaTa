// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.BusinessListObjectMetadataBusiness
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Version(1)]
  [MarshalingBehavior]
  [Activatable(typeof (__IBusinessListObjectMetadataBusinessFactory), 1)]
  [Threading]
  [WebHostHidden]
  public sealed class BusinessListObjectMetadataBusiness : 
    __IBusinessListObjectMetadataBusinessPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern BusinessListObjectMetadataBusiness([In] string id, [In] string name);

    public extern string Id { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Name { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
