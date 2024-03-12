// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.__ITileIdFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit
{
  [ExclusiveTo(typeof (TileId))]
  [Guid(2166393048, 56240, 16072, 137, 158, 17, 0, 176, 211, 21, 68)]
  [Version(1)]
  [WebHostHidden]
  internal interface __ITileIdFactory
  {
    [Overload("CreateInstance1")]
    TileId CreateInstance([In] uint x, [In] uint y, [In] uint z);
  }
}
