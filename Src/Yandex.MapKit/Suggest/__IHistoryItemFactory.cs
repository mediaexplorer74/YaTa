// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Suggest.__IHistoryItemFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Suggest
{
  [WebHostHidden]
  [Guid(2653867156, 22152, 15097, 138, 7, 254, 107, 191, 109, 22, 109)]
  [ExclusiveTo(typeof (HistoryItem))]
  [Version(1)]
  internal interface __IHistoryItemFactory
  {
    [Overload("CreateInstance1")]
    HistoryItem CreateInstance([In] SpannableString spannableString);
  }
}
