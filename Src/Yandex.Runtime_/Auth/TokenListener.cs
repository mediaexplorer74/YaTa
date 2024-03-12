// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Auth.TokenListener
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime.Auth
{
  [Guid(2982317011, 33210, 15077, 182, 96, 190, 150, 187, 103, 208, 237)]
  [WebHostHidden]
  [Version(1)]
  public interface TokenListener
  {
    void OnTokenReceived([In] string token);

    void OnPasswordRequired([In] object data);

    void OnTokenRefreshFailed([In] string message);
  }
}
