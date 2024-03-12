// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.Category
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [WebHostHidden]
  [Threading]
  [MarshalingBehavior]
  [Version(1)]
  [Activatable(typeof (__ICategoryFactory), 1)]
  public sealed class Category : __ICategoryPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Category([In] string name, [In] string categoryClass);

    public extern string Name { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string CategoryClass { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
