// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.ResourceUrlProvider.ResourceUrlProvider
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.ResourceUrlProvider
{
  [Guid(821166194, 32268, 12944, 178, 61, 158, 186, 208, 84, 49, 234)]
  [Version(1)]
  [WebHostHidden]
  public interface ResourceUrlProvider
  {
    string FormatUrl([In] string resourceId);
  }
}
