// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Internal.TestSupport.LiteTestStructure
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime.Internal.TestSupport
{
  [Version(1)]
  [Activatable(typeof (__ILiteTestStructureFactory), 1)]
  [MarshalingBehavior]
  [Threading]
  [WebHostHidden]
  public sealed class LiteTestStructure : __ILiteTestStructurePublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern LiteTestStructure(
      [In] bool b,
      [In] string text,
      [In] string optionalText,
      [In] TimeSpan interval,
      [In] DateTime timestamp);

    public extern bool B { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Text { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string OptionalText { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern TimeSpan Interval { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern DateTime Timestamp { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
