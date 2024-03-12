// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.RoadEvents.__ITextEntryFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.RoadEvents
{
  [Guid(4249578862, 60051, 15608, 185, 168, 89, 212, 195, 24, 243, 15)]
  [WebHostHidden]
  [ExclusiveTo(typeof (TextEntry))]
  [Version(1)]
  internal interface __ITextEntryFactory
  {
    [Overload("CreateInstance1")]
    TextEntry CreateInstance([In] string text);
  }
}
