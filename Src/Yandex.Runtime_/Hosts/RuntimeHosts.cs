// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Hosts.RuntimeHosts
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime.Hosts
{
  [WebHostHidden]
  [Activatable(1)]
  [Threading]
  [Version(1)]
  [Static(typeof (__IRuntimeHostsStatics), 1)]
  [MarshalingBehavior]
  public sealed class RuntimeHosts : __IRuntimeHostsPublicNonVirtuals
  {
    public static extern IVectorView<string> Hosts { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern RuntimeHosts();
  }
}
