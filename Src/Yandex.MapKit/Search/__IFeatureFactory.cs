// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IFeatureFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Guid(222880146, 39698, 13012, 185, 205, 28, 246, 148, 136, 199, 66)]
  [Version(1)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Feature))]
  internal interface __IFeatureFactory
  {
    [Overload("CreateInstance1")]
    Feature CreateInstance([In] string id, [In] FeatureVariantValue value, [In] string name, [In] string aref);
  }
}
