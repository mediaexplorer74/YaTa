// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IRouterFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [WebHostHidden]
  [Guid(3317840599, 59744, 15164, 178, 228, 3, 157, 211, 5, 151, 49)]
  [Version(1)]
  [ExclusiveTo(typeof (Router))]
  internal interface __IRouterFactory
  {
    [Overload("CreateInstance1")]
    Router CreateInstance([In] IVectorView<RouterType> types);
  }
}
