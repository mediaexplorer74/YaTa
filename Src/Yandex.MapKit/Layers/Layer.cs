// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Layers.Layer
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Layers
{
  [Guid(4171948749, 7607, 12444, 177, 103, 164, 11, 67, 249, 177, 54)]
  [WebHostHidden]
  [Version(1)]
  public interface Layer
  {
    void Activate([In] bool on);

    void Invalidate([In] string version);

    void Clear();

    void Remove();

    bool Valid { get; }
  }
}
