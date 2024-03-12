// Decompiled with JetBrains decompiler
// Type: Yandex.Maps.Recording.RecordCollector
// Assembly: Yandex.Maps.Recording, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 50EEDF86-9D89-467B-BD6C-212DF28AA2C9
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Maps.Recording.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Maps.Recording
{
  [Version(1)]
  [WebHostHidden]
  [Guid(811411803, 27176, 15676, 138, 247, 143, 78, 218, 67, 35, 14)]
  public interface RecordCollector
  {
    void StartReport();

    void FinishReport();

    void MarkProblem();

    IVectorView<Report> Reports();

    void Clear();

    bool Valid { get; }
  }
}
