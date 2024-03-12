// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Logging.Logger
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime.Logging
{
  [MarshalingBehavior]
  [Threading]
  [Static(typeof (__ILoggerStatics), 1)]
  [Activatable(1)]
  [Version(1)]
  [WebHostHidden]
  public sealed class Logger : __ILoggerPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern void Error([In] string str);

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern void Warn([In] string str);

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern void Info([In] string str);

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern void Debug([In] string str);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Logger();
  }
}
