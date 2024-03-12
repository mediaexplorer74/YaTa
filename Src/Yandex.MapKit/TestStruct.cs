// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.TestStruct
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit
{
  [WebHostHidden]
  [Threading]
  [Static(typeof (__ITestStructStatics), 1)]
  [Version(1)]
  [MarshalingBehavior]
  [Activatable(typeof (__ITestStructFactory), 1)]
  public sealed class TestStruct : __ITestStructPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern TestStruct From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern TestStruct([In] uint value);

    public extern uint Value { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
