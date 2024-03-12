// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Suggest.__IHistoryItemStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Suggest
{
  [ExclusiveTo(typeof (HistoryItem))]
  [Version(1)]
  [Guid(3724170291, 29947, 15232, 135, 251, 0, 129, 156, 173, 151, 102)]
  [WebHostHidden]
  internal interface __IHistoryItemStatics
  {
    HistoryItem From([In] AnyCollection anyCollection);
  }
}
