// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Logging.Logging
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime.Logging
{
  [Version(1)]
  [WebHostHidden]
  [Guid(3264371369, 48052, 15730, 150, 113, 186, 17, 75, 17, 147, 83)]
  public interface Logging
  {
    void Subscribe([In] LogListener logListener);

    void Unsubscribe([In] LogListener logListener);

    bool Valid { get; }
  }
}
