// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Coverage.__IRegionPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Coverage
{
  [ExclusiveTo(typeof (Region))]
  [Guid(2244084488, 18059, 14110, 145, 186, 229, 51, 151, 233, 186, 188)]
  [Version(1)]
  [WebHostHidden]
  internal interface __IRegionPublicNonVirtuals
  {
    int Id { get; }

    int ZoomMin { get; }

    int ZoomMax { get; }
  }
}
