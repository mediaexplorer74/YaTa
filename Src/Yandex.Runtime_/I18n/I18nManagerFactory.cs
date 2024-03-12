// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.I18n.I18nManagerFactory
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime.I18n
{
  [WebHostHidden]
  [Activatable(1)]
  [MarshalingBehavior]
  [Threading]
  [Version(1)]
  [Static(typeof (__II18nManagerFactoryStatics), 1)]
  public sealed class I18nManagerFactory : __II18nManagerFactoryPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern I18nManager GetI18nManagerInstance();

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern I18nManagerFactory();
  }
}
