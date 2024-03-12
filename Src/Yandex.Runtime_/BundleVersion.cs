// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.BundleVersion
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime
{
  [Static(typeof (__IBundleVersionStatics), 1)]
  [MarshalingBehavior]
  [Version(1)]
  [Threading]
  [Activatable(1)]
  public sealed class BundleVersion : __IBundleVersionPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern string get();

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern BundleVersion();
  }
}
