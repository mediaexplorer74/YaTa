// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.Internal.__IRawAnnotationSchemeFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving.Internal
{
  [Version(1)]
  [Guid(1956997886, 47141, 13578, 148, 87, 181, 185, 198, 87, 146, 82)]
  [ExclusiveTo(typeof (RawAnnotationScheme))]
  [WebHostHidden]
  internal interface __IRawAnnotationSchemeFactory
  {
    [Overload("CreateInstance1")]
    RawAnnotationScheme CreateInstance([In] int count, [In] AnnotationSchemeID schemeId);
  }
}
