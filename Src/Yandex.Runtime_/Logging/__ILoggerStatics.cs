// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Logging.__ILoggerStatics
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime.Logging
{
  [Guid(3569968650, 36753, 13097, 142, 64, 99, 133, 146, 144, 61, 33)]
  [ExclusiveTo(typeof (Logger))]
  [WebHostHidden]
  [Version(1)]
  internal interface __ILoggerStatics
  {
    void Error([In] string str);

    void Warn([In] string str);

    void Info([In] string str);

    void Debug([In] string str);
  }
}
