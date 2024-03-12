// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Glyphs.GlyphUrlProvider
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Glyphs
{
  [Version(1)]
  [Guid(1637487157, 50326, 15381, 131, 69, 184, 200, 8, 238, 5, 11)]
  [WebHostHidden]
  public interface GlyphUrlProvider
  {
    [Overload("FormatUrl1")]
    string FormatUrl([In] string fontId, [In] GlyphIdRange range);

    [Overload("FormatUrl2")]
    string FormatUrl([In] string fontId);
  }
}
