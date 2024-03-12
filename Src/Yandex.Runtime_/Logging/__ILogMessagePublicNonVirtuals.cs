// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Logging.__ILogMessagePublicNonVirtuals
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime.Logging
{
  [ExclusiveTo(typeof (LogMessage))]
  [WebHostHidden]
  [Guid(3389059117, 28657, 13575, 164, 156, 111, 129, 7, 3, 189, 113)]
  [Version(1)]
  internal interface __ILogMessagePublicNonVirtuals
  {
    DateTime Time { get; }

    LogMessageLogLevel Level { get; }

    string Scope { get; }

    string Message { get; }

    string VerboseInfo { get; }
  }
}
