// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Reviews.Tag
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Reviews
{
  [Version(1)]
  [Threading]
  [MarshalingBehavior]
  [Activatable(typeof (__ITagFactory), 1)]
  [WebHostHidden]
  public sealed class Tag : __ITagPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Tag([In] string name, [In] int value, [In] string caption);

    public extern string Name { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern int Value { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Caption { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
