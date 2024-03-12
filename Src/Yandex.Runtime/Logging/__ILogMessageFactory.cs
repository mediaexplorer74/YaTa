// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Logging.__ILogMessageFactory
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime.Logging
{
  [Version(1)]
  [WebHostHidden]
  [ExclusiveTo(typeof (LogMessage))]
  [Guid(3399626902, 33834, 14109, 151, 212, 171, 189, 8, 243, 238, 137)]
  internal interface __ILogMessageFactory
  {
    [Overload("CreateInstance1")]
    LogMessage CreateInstance(
      [In] DateTime time,
      [In] LogMessageLogLevel level,
      [In] string scope,
      [In] string message,
      [In] string verboseInfo);
  }
}
