// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.Internal.__IRawAnnotationSchemePublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving.Internal
{
  [Guid(28362838, 8617, 13534, 149, 198, 21, 93, 150, 125, 3, 122)]
  [Version(1)]
  [WebHostHidden]
  [ExclusiveTo(typeof (RawAnnotationScheme))]
  internal interface __IRawAnnotationSchemePublicNonVirtuals
  {
    int Count { get; }

    AnnotationSchemeID SchemeId { get; }
  }
}
