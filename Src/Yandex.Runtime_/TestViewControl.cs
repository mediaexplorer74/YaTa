// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.TestViewControl
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

#nullable disable
namespace Yandex.Runtime
{
  [WebHostHidden]
  [Version(1)]
  [MarshalingBehavior]
  [Activatable(1)]
  [Threading]
  public sealed class TestViewControl : Grid, __ITestViewControlPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern TestViewControl();

    public extern PlatformView PlatformView { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
