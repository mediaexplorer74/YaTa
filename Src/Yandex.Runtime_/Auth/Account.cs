// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Auth.Account
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime.Auth
{
  [WebHostHidden]
  [Version(1)]
  [Guid(1065727654, 62025, 13551, 182, 82, 159, 28, 201, 19, 76, 107)]
  public interface Account
  {
    string Uid();

    void RequestToken([In] TokenListener tokenListener);

    void InvalidateToken([In] string token);
  }
}
