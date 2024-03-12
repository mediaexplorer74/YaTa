// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.RoadEvents.TextEntry
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.RoadEvents
{
  [Version(1)]
  [Activatable(typeof (__ITextEntryFactory), 1)]
  [MarshalingBehavior]
  [Threading]
  [WebHostHidden]
  public sealed class TextEntry : __ITextEntryPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern TextEntry([In] string text);

    public extern string Text { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
