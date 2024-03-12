// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.__IUturnMetadataFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [Version(1)]
  [Guid(1674187140, 47292, 12612, 154, 192, 43, 198, 246, 170, 187, 13)]
  [WebHostHidden]
  [ExclusiveTo(typeof (UturnMetadata))]
  internal interface __IUturnMetadataFactory
  {
    [Overload("CreateInstance1")]
    UturnMetadata CreateInstance([In] double length);
  }
}
