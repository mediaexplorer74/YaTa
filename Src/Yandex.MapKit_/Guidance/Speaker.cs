// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.Speaker
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [Version(1)]
  [WebHostHidden]
  [Guid(2233488861, 19995, 14694, 154, 198, 154, 211, 100, 92, 19, 41)]
  public interface Speaker
  {
    void Say([In] Phrase phrase);

    double Duration([In] Phrase phrase);

    void Reset();
  }
}
