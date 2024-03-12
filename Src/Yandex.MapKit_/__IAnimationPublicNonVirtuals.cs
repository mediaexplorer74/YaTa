// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.__IAnimationPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit
{
  [WebHostHidden]
  [Version(1)]
  [ExclusiveTo(typeof (Animation))]
  [Guid(3748050855, 64420, 16356, 179, 242, 94, 64, 199, 122, 131, 162)]
  internal interface __IAnimationPublicNonVirtuals
  {
    AnimationType Type { get; }

    float Duration { get; }
  }
}
