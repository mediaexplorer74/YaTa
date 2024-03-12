// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Logging.LogMessage
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime.Logging
{
  [MarshalingBehavior]
  [Version(1)]
  [WebHostHidden]
  [Activatable(typeof (__ILogMessageFactory), 1)]
  [Threading]
  public sealed class LogMessage : __ILogMessagePublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern LogMessage(
      [In] DateTime time,
      [In] LogMessageLogLevel level,
      [In] string scope,
      [In] string message,
      [In] string verboseInfo);

    public extern DateTime Time { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern LogMessageLogLevel Level { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Scope { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Message { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string VerboseInfo { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
