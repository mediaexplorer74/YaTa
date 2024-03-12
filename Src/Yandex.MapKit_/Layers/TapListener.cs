// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Layers.TapListener
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Layers
{
  [Guid(1833688148, 42552, 14444, 144, 63, 236, 111, 41, 113, 249, 5)]
  [Version(1)]
  [WebHostHidden]
  public interface TapListener
  {
    void OnLayerTap([In] string layer, [In] string id, [In] LayerParams @params);
  }
}
