// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.__IPlatformViewPublicNonVirtuals
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

#nullable disable
namespace Yandex.Runtime
{
  [ExclusiveTo(typeof (PlatformView))]
  [Guid(3551895349, 55127, 14401, 147, 99, 221, 4, 201, 36, 1, 36)]
  [WebHostHidden]
  [Version(1)]
  internal interface __IPlatformViewPublicNonVirtuals
  {
    SwapChainPanel GetGLPanel();
  }
}
