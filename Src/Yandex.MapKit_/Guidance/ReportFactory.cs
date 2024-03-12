// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.ReportFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [WebHostHidden]
  [Version(1)]
  [Guid(1480601846, 62415, 14517, 129, 205, 248, 141, 220, 147, 173, 84)]
  public interface ReportFactory
  {
    Report CreateReport([In] byte[] data);
  }
}
