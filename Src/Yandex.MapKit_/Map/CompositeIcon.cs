// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Map.CompositeIcon
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime.Image;

#nullable disable
namespace Yandex.MapKit.Map
{
  [Version(1)]
  [Guid(202744278, 44854, 13349, 185, 3, 254, 137, 127, 137, 151, 236)]
  [WebHostHidden]
  public interface CompositeIcon
  {
    void SetIcon([In] string name, [In] ImageProvider image, [In] IconStyle style);

    void SetIconStyle([In] string name, [In] IconStyle style);

    void RemoveIcon([In] string name);

    void RemoveAll();

    bool Valid { get; }
  }
}
