// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.Internal.__IRawTransferFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit.Internal
{
  [Version(1)]
  [ExclusiveTo(typeof (RawTransfer))]
  [WebHostHidden]
  [Guid(1656565978, 6367, 12989, 150, 149, 179, 210, 206, 192, 121, 78)]
  internal interface __IRawTransferFactory
  {
    [Overload("CreateInstance1")]
    RawTransfer CreateInstance([In] RawConstructions constructions);
  }
}
