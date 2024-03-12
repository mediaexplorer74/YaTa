// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.ConditionsListener
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [Guid(4256630668, 30203, 12833, 154, 214, 10, 160, 58, 89, 147, 98)]
  [Version(1)]
  [WebHostHidden]
  public interface ConditionsListener
  {
    void OnConditionsUpdated();

    void OnConditionsOutdated();
  }
}
