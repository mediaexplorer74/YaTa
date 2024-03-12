// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Auth.PasswordRequiredError
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime.Auth
{
  [Version(1)]
  [WebHostHidden]
  [Guid(912204768, 21646, 15112, 185, 102, 89, 165, 251, 153, 73, 212)]
  public interface PasswordRequiredError : Error
  {
    object Data { get; }
  }
}
