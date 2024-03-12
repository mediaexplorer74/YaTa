// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Logging.__ILoggingFactoryStatics
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime.Logging
{
  [ExclusiveTo(typeof (LoggingFactory))]
  [Guid(147561173, 6519, 12933, 131, 152, 8, 183, 74, 73, 106, 58)]
  [Version(1)]
  [WebHostHidden]
  internal interface __ILoggingFactoryStatics
  {
    global::Yandex.Runtime.Logging.Logging GetLogging();
  }
}
