// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Suggest.HistoryManager
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Suggest
{
  [Version(1)]
  [WebHostHidden]
  [Guid(3578235955, 43149, 14805, 170, 110, 73, 209, 120, 198, 41, 127)]
  public interface HistoryManager
  {
    void Add([In] string item);

    void SelectRecent(
      [In] uint maxResults,
      [In] OnHistoryResponse onHistoryResponse,
      [In] OnHistoryError onHistoryError);

    void SelectMatched(
      [In] string pattern,
      [In] uint maxResults,
      [In] OnHistoryResponse onHistoryResponse,
      [In] OnHistoryError onHistoryError);

    void Clear();

    void Cancel();
  }
}
