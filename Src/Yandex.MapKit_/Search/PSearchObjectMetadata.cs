// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.PSearchObjectMetadata
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Search
{
  [MarshalingBehavior]
  [Threading]
  [Version(1)]
  [Activatable(typeof (__IPSearchObjectMetadataFactory), 1)]
  [Static(typeof (__IPSearchObjectMetadataStatics), 1)]
  [WebHostHidden]
  public sealed class PSearchObjectMetadata : __IPSearchObjectMetadataPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern PSearchObjectMetadata From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern PSearchObjectMetadata(
      [In] string name,
      [In] string address,
      [In] string category,
      [In] LocalizedValue distance);

    public extern string Name { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Address { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Category { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern LocalizedValue Distance { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
