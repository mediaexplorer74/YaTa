// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.__IScreenRectPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit
{
  [Guid(3040578831, 57375, 15854, 153, 194, 140, 193, 133, 74, 80, 108)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ScreenRect))]
  [Version(1)]
  internal interface __IScreenRectPublicNonVirtuals
  {
    ScreenPoint TopLeft { get; }

    ScreenPoint BottomRight { get; }
  }
}
