// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.I18nTime
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit
{
  [WebHostHidden]
  [MarshalingBehavior]
  [Activatable(typeof (__II18nTimeFactory), 1)]
  [Threading]
  [Version(1)]
  public sealed class I18nTime : __II18nTimePublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern I18nTime([In] long value, [In] int tzOffset, [In] string text);

    public extern long Value { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern int TzOffset { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Text { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
