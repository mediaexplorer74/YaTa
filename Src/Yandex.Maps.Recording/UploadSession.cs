// Decompiled with JetBrains decompiler
// Type: Yandex.Maps.Recording.UploadSession
// Assembly: Yandex.Maps.Recording, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 50EEDF86-9D89-467B-BD6C-212DF28AA2C9
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Maps.Recording.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Maps.Recording
{
  [WebHostHidden]
  [Guid(1148294223, 20658, 13769, 129, 198, 196, 70, 136, 208, 94, 115)]
  [Version(1)]
  public interface UploadSession
  {
    void Retry([In] OnUploadResult onUploadResult, [In] OnUploadError onUploadError);

    void Cancel();
  }
}
