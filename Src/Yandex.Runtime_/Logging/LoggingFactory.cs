// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Logging.LoggingFactory
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime.Logging
{
  [WebHostHidden]
  [Static(typeof (__ILoggingFactoryStatics), 1)]
  [Version(1)]
  [Activatable(1)]
  [Threading]
  [MarshalingBehavior]
  public sealed class LoggingFactory : __ILoggingFactoryPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern global::Yandex.Runtime.Logging.Logging GetLogging();

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern LoggingFactory();
  }
}
