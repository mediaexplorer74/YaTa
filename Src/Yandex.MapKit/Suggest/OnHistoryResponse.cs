// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Suggest.OnHistoryResponse
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Suggest
{
  [Guid(1887342489, 63547, 13018, 136, 82, 201, 44, 76, 83, 58, 205)]
  [Version(1)]
  [WebHostHidden]
  public delegate void OnHistoryResponse([In] IVectorView<HistoryItem> result);
}
