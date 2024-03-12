// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.Internal.__IRawAnnotationSchemesPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving.Internal
{
  [Version(1)]
  [WebHostHidden]
  [ExclusiveTo(typeof (RawAnnotationSchemes))]
  [Guid(2848268274, 20004, 16211, 149, 235, 164, 136, 85, 110, 23, 250)]
  internal interface __IRawAnnotationSchemesPublicNonVirtuals
  {
    IVectorView<RawAnnotationScheme> Schemes { get; }
  }
}
