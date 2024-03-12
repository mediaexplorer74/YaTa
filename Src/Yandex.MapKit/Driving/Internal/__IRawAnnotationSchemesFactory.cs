// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.Internal.__IRawAnnotationSchemesFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving.Internal
{
  [ExclusiveTo(typeof (RawAnnotationSchemes))]
  [WebHostHidden]
  [Guid(3605284840, 28327, 15263, 145, 218, 125, 32, 6, 234, 221, 214)]
  [Version(1)]
  internal interface __IRawAnnotationSchemesFactory
  {
    [Overload("CreateInstance1")]
    RawAnnotationSchemes CreateInstance([In] IVectorView<RawAnnotationScheme> schemes);
  }
}
