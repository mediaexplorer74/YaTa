// Decompiled with JetBrains decompiler
// Type: Yandex.Maps.Recording.Report
// Assembly: Yandex.Maps.Recording, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 50EEDF86-9D89-467B-BD6C-212DF28AA2C9
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Maps.Recording.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Maps.Recording
{
  [Guid(3390273681, 19505, 13572, 154, 232, 234, 82, 95, 110, 204, 208)]
  [WebHostHidden]
  [Version(1)]
  public interface Report
  {
    UploadSession Submit(
      [In] string summary,
      [In] string userDescription,
      [In] OnUploadResult onUploadResult,
      [In] OnUploadError onUploadError);

    string DisplayName { get; }

    bool HasMarkedProblem { get; }

    string IssueId { get; }
  }
}
