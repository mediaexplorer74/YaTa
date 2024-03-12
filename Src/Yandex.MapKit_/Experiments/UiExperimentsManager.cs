// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Experiments.UiExperimentsManager
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Experiments
{
  [WebHostHidden]
  [Guid(2577099710, 34566, 15113, 174, 188, 163, 174, 95, 238, 15, 147)]
  [Version(1)]
  public interface UiExperimentsManager
  {
    IMapView<string, string> Parameters { get; }

    string GetValue([In] string key);

    void Subscribe([In] UiExperimentsListener experimentsListener);

    void Unsubscribe([In] UiExperimentsListener experimentsListener);

    bool Valid { get; }
  }
}
