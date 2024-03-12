// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Time.AdjustedClock
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Time
{
  [WebHostHidden]
  [Version(1)]
  [Guid(2168870012, 24802, 14155, 181, 2, 216, 208, 81, 207, 135, 187)]
  public interface AdjustedClock
  {
    DateTime Now();

    bool Valid { get; }
  }
}
