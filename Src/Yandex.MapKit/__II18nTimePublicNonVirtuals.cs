// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.__II18nTimePublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit
{
  [WebHostHidden]
  [Version(1)]
  [ExclusiveTo(typeof (I18nTime))]
  [Guid(2827997865, 60326, 14417, 169, 102, 102, 172, 55, 176, 217, 54)]
  internal interface __II18nTimePublicNonVirtuals
  {
    long Value { get; }

    int TzOffset { get; }

    string Text { get; }
  }
}
