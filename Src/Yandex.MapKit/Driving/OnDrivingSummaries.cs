// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.OnDrivingSummaries
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [Version(1)]
  [WebHostHidden]
  [Guid(63680664, 32364, 16281, 138, 242, 129, 150, 97, 59, 32, 196)]
  public delegate void OnDrivingSummaries([In] IVectorView<Summary> summaries);
}
