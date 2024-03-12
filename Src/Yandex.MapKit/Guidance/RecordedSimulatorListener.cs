// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.RecordedSimulatorListener
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [Version(1)]
  [Guid(1853204902, 5596, 12569, 158, 180, 56, 98, 56, 195, 246, 119)]
  [WebHostHidden]
  public interface RecordedSimulatorListener
  {
    void OnLocationUpdated();

    void OnRouteUpdated();

    void OnProblemMark();

    void OnFinish();
  }
}
