// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Internal.TestSupport.TestStructure
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime.Internal.TestSupport
{
  [Threading]
  [Version(1)]
  [MarshalingBehavior]
  [WebHostHidden]
  [Static(typeof (__ITestStructureStatics), 1)]
  [Activatable(typeof (__ITestStructureFactory), 1)]
  public sealed class TestStructure : __ITestStructurePublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern TestStructure From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern TestStructure(
      [In] bool b,
      [In] string text,
      [In] string optionalText,
      [In] IVectorView<int> intVector,
      [In] TimeSpan interval,
      [In] DateTime timestamp);

    public extern bool B { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Text { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string OptionalText { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<int> IntVector { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern TimeSpan Interval { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern DateTime Timestamp { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
