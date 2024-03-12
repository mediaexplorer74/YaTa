// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.RoadEvents.RoadEventFailedError
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.RoadEvents
{
  [WebHostHidden]
  [Version(1)]
  [Guid(141413735, 45865, 13604, 159, 94, 15, 227, 68, 234, 180, 66)]
  public interface RoadEventFailedError : Error
  {
    RoadEventFailedErrorCode Code { get; }

    string Description { get; }
  }
}
