// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Coverage.IsCoveredSession
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Coverage
{
  [Version(1)]
  [WebHostHidden]
  [Guid(1539655292, 16475, 13811, 138, 228, 123, 15, 45, 251, 194, 220)]
  public interface IsCoveredSession
  {
    void Retry([In] OnCoveredResponse onCoveredResponse, [In] OnCoveredError onCoveredError);

    void Cancel();
  }
}
