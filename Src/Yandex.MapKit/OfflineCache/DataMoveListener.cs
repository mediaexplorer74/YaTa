// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.OfflineCache.DataMoveListener
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.OfflineCache
{
  [Version(1)]
  [WebHostHidden]
  [Guid(4009703931, 39601, 13540, 154, 200, 152, 114, 197, 166, 4, 203)]
  public interface DataMoveListener
  {
    void OnDataMoveProgress([In] int percent);

    void OnDataMoveCompleted();

    void OnDataMoveError([In] Error error);
  }
}
