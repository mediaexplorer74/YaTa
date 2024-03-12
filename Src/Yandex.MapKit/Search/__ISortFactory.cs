// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__ISortFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [WebHostHidden]
  [Version(1)]
  [Guid(2795856319, 32662, 15721, 163, 245, 166, 14, 108, 159, 37, 125)]
  [ExclusiveTo(typeof (Sort))]
  internal interface __ISortFactory
  {
    [Overload("CreateInstance1")]
    Sort CreateInstance([In] SortType type, [In] IReference<SortOrigin> origin);
  }
}
