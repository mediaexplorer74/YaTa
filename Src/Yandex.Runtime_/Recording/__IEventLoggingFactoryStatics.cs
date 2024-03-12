// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Recording.__IEventLoggingFactoryStatics
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime.Recording
{
  [ExclusiveTo(typeof (EventLoggingFactory))]
  [WebHostHidden]
  [Guid(2442739081, 5098, 14231, 152, 218, 180, 148, 144, 51, 58, 165)]
  [Version(1)]
  internal interface __IEventLoggingFactoryStatics
  {
    EventLogging GetEventLogging();
  }
}
