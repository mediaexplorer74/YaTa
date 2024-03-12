// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.Internal.__IRawConstructionsFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit.Internal
{
  [WebHostHidden]
  [Guid(262580346, 27934, 15215, 129, 44, 235, 29, 227, 75, 73, 182)]
  [Version(1)]
  [ExclusiveTo(typeof (RawConstructions))]
  internal interface __IRawConstructionsFactory
  {
    [Overload("CreateInstance1")]
    RawConstructions CreateInstance([In] IVectorView<RawConstruction> constructions);
  }
}
