// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.Internal.__ILaneBitmapFactoryStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving.Internal
{
  [ExclusiveTo(typeof (LaneBitmapFactory))]
  [Version(1)]
  [Guid(1194479972, 61765, 13613, 157, 253, 58, 190, 8, 224, 95, 56)]
  [WebHostHidden]
  internal interface __ILaneBitmapFactoryStatics
  {
    LaneBitmap CreateLaneBitmap([In] IVectorView<Lane> laneSigns);
  }
}
