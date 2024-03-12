// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.PlatformView
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
  [Threading]
  [Version(1)]
  [Activatable(1)]
  [MarshalingBehavior]
  public sealed class PlatformView : __IPlatformViewPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern PlatformView();

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern SwapChainPanel GetGLPanel();
  }
}
