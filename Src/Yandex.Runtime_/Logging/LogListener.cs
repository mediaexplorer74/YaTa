// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Logging.LogListener
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime.Logging
{
  [Guid(3478838123, 51155, 14784, 155, 141, 197, 250, 247, 83, 189, 17)]
  [Version(1)]
  [WebHostHidden]
  public interface LogListener
  {
    void OnMessageRecieved([In] LogMessage message);
  }
}
