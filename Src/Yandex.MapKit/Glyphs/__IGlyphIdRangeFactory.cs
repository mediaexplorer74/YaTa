// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Glyphs.__IGlyphIdRangeFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Glyphs
{
  [WebHostHidden]
  [Guid(3344891374, 26425, 15477, 159, 248, 34, 219, 133, 146, 212, 27)]
  [ExclusiveTo(typeof (GlyphIdRange))]
  [Version(1)]
  internal interface __IGlyphIdRangeFactory
  {
    [Overload("CreateInstance1")]
    GlyphIdRange CreateInstance([In] uint firstGlyphId, [In] uint lastGlyphId);
  }
}
