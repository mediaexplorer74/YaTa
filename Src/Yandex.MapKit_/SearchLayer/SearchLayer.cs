// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.SearchLayer.SearchLayer
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Search;

#nullable disable
namespace Yandex.MapKit.SearchLayer
{
  [WebHostHidden]
  [Version(1)]
  [Guid(113261098, 58863, 14647, 174, 120, 93, 14, 220, 234, 214, 27)]
  public interface SearchLayer
  {
    void Update([In] Response response);

    void Clear();

    void Activate([In] bool on);

    bool Valid { get; }
  }
}
