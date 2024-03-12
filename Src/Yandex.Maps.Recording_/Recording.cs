// Decompiled with JetBrains decompiler
// Type: Yandex.Maps.Recording.Recording
// Assembly: Yandex.Maps.Recording, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 50EEDF86-9D89-467B-BD6C-212DF28AA2C9
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Maps.Recording.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime.Auth;

#nullable disable
namespace Yandex.Maps.Recording
{
  [global::Windows.Foundation.Metadata.Version(1)]
  [WebHostHidden]
  [Guid(579107894, 17111, 13916, 188, 74, 1, 153, 146, 184, 67, 2)]
  public interface Recording
  {
    void Initialize([In] string uuid, [In] string deviceId);

    void SetAccount([In] Account account);

    global::Yandex.Maps.Recording.RecordCollector RecordCollector();

    string Version { get; }

    bool Valid { get; }
  }
}
