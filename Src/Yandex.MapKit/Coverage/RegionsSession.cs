// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Coverage.RegionsSession
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Coverage
{
  [WebHostHidden]
  [Guid(3398581021, 53037, 15378, 147, 82, 182, 136, 222, 196, 157, 187)]
  [Version(1)]
  public interface RegionsSession
  {
    void Retry([In] OnRegionsResponse onRegionsResponse, [In] OnRegionsError onRegionsError);

    void Cancel();
  }
}
