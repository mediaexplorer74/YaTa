// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.Internal.__IRawLaneSignsFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving.Internal
{
  [Version(1)]
  [Guid(1327876791, 52125, 12803, 144, 228, 91, 156, 197, 106, 180, 20)]
  [WebHostHidden]
  [ExclusiveTo(typeof (RawLaneSigns))]
  internal interface __IRawLaneSignsFactory
  {
    [Overload("CreateInstance1")]
    RawLaneSigns CreateInstance([In] IVectorView<RawLaneSign> laneSigns);
  }
}
