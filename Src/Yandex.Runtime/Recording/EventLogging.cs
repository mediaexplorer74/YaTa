// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Recording.EventLogging
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime.Recording
{
  [WebHostHidden]
  [Version(1)]
  [Guid(702294516, 25609, 14245, 161, 156, 202, 211, 107, 63, 67, 238)]
  public interface EventLogging
  {
    void Subscribe([In] EventListener eventListener);

    void Unsubscribe([In] EventListener eventListener);

    bool Valid { get; }
  }
}
