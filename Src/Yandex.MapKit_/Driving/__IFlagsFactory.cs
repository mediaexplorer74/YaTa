// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.__IFlagsFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [Guid(2356041626, 28948, 12965, 160, 233, 249, 186, 62, 7, 16, 130)]
  [WebHostHidden]
  [Version(1)]
  [ExclusiveTo(typeof (Flags))]
  internal interface __IFlagsFactory
  {
    [Overload("CreateInstance1")]
    Flags CreateInstance(
      [In] bool blocked,
      [In] bool hasFerries,
      [In] bool hasTolls,
      [In] bool guidanceForbidden,
      [In] bool crossesBorders,
      [In] bool requiresAccessPass,
      [In] bool forParking);
  }
}
