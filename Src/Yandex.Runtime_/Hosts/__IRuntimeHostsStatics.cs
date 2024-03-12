// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Hosts.__IRuntimeHostsStatics
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime.Hosts
{
  [Guid(2926242312, 48995, 13240, 181, 125, 234, 240, 184, 101, 222, 126)]
  [Version(1)]
  [ExclusiveTo(typeof (RuntimeHosts))]
  [WebHostHidden]
  internal interface __IRuntimeHostsStatics
  {
    IVectorView<string> Hosts { get; }
  }
}
