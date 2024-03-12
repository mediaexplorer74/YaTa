// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.LocalizedValue
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit
{
  [Activatable(typeof (__ILocalizedValueFactory), 1)]
  [Version(1)]
  [Threading]
  [WebHostHidden]
  [MarshalingBehavior]
  public sealed class LocalizedValue : __ILocalizedValuePublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern LocalizedValue([In] double value, [In] string text);

    public extern double Value { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Text { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
