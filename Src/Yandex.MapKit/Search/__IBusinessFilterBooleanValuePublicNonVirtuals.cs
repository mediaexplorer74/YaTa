// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IBusinessFilterBooleanValuePublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [ExclusiveTo(typeof (BusinessFilterBooleanValue))]
  [WebHostHidden]
  [Guid(350716102, 52769, 15592, 138, 99, 69, 49, 217, 198, 209, 186)]
  [Version(1)]
  internal interface __IBusinessFilterBooleanValuePublicNonVirtuals
  {
    bool Value { get; }

    IReference<bool> Selected { get; }
  }
}
