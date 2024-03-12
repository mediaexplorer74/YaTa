// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.SectionMetadata
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [WebHostHidden]
  [Activatable(typeof (__ISectionMetadataFactory), 1)]
  [Version(1)]
  [Static(typeof (__ISectionMetadataStatics), 1)]
  [Threading]
  [MarshalingBehavior]
  public sealed class SectionMetadata : __ISectionMetadataPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern SectionMetadata From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern SectionMetadata([In] Weight weight, [In] SectionMetadataSectionData data);

    public extern Weight Weight { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern SectionMetadataSectionData Data { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
