// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IStopStyleFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [WebHostHidden]
  [Version(1)]
  [Guid(1069638591, 24701, 14225, 169, 100, 72, 135, 107, 242, 59, 205)]
  [ExclusiveTo(typeof (StopStyle))]
  internal interface __IStopStyleFactory
  {
    [Overload("CreateInstance1")]
    StopStyle CreateInstance([In] int color);
  }
}
