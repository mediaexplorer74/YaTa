// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.__IGeoObjectStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit
{
  [Guid(2008204213, 61043, 14739, 146, 250, 59, 233, 91, 225, 10, 95)]
  [ExclusiveTo(typeof (GeoObject))]
  [WebHostHidden]
  [Version(1)]
  internal interface __IGeoObjectStatics
  {
    GeoObject From([In] AnyCollection anyCollection);
  }
}
