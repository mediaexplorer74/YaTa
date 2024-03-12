// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.Internal.__IRawLaneSignFactory
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
  [WebHostHidden]
  [Guid(1012467353, 23838, 15456, 163, 15, 110, 192, 41, 86, 187, 211)]
  [ExclusiveTo(typeof (RawLaneSign))]
  internal interface __IRawLaneSignFactory
  {
    [Overload("CreateInstance1")]
    RawLaneSign CreateInstance([In] uint position, [In] IVectorView<Lane> lanes);
  }
}
