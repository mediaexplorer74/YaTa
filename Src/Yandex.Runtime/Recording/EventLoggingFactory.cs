// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Recording.EventLoggingFactory
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime.Recording
{
  [MarshalingBehavior]
  [Static(typeof (__IEventLoggingFactoryStatics), 1)]
  [Activatable(1)]
  [WebHostHidden]
  [Threading]
  [Version(1)]
  public sealed class EventLoggingFactory : __IEventLoggingFactoryPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern EventLogging GetEventLogging();

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern EventLoggingFactory();
  }
}
