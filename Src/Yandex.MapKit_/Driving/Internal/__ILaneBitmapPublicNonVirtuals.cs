// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.Internal.__ILaneBitmapPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving.Internal
{
  [WebHostHidden]
  [Version(1)]
  [Guid(2979544321, 38623, 16130, 165, 237, 98, 49, 51, 104, 188, 57)]
  [ExclusiveTo(typeof (LaneBitmap))]
  internal interface __ILaneBitmapPublicNonVirtuals
  {
    int Width { get; }

    int Height { get; }

    byte[] Data { get; }
  }
}
