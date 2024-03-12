// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.Internal.__ILaneBitmapFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving.Internal
{
  [WebHostHidden]
  [Version(1)]
  [Guid(432667638, 59846, 13871, 138, 129, 5, 184, 85, 218, 190, 140)]
  [ExclusiveTo(typeof (LaneBitmap))]
  internal interface __ILaneBitmapFactory
  {
    [Overload("CreateInstance1")]
    LaneBitmap CreateInstance([In] int width, [In] int height, [In] byte[] data);
  }
}
