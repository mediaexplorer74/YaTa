// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.__ISummaryFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [Guid(1009920693, 30806, 12358, 163, 71, 113, 210, 40, 171, 107, 148)]
  [Version(1)]
  [ExclusiveTo(typeof (Summary))]
  [WebHostHidden]
  internal interface __ISummaryFactory
  {
    [Overload("CreateInstance1")]
    Summary CreateInstance([In] Weight weight, [In] Flags flags);
  }
}
