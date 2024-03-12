// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.__IAnnotationFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [Guid(2324825857, 57255, 14801, 176, 104, 220, 48, 234, 86, 50, 95)]
  [WebHostHidden]
  [Version(1)]
  [ExclusiveTo(typeof (Annotation))]
  internal interface __IAnnotationFactory
  {
    [Overload("CreateInstance1")]
    Annotation CreateInstance(
      [In] IReference<Action> action,
      [In] string toponym,
      [In] string descriptionText,
      [In] ActionMetadata actionMetadata,
      [In] IVectorView<Landmark> landmarks);
  }
}
