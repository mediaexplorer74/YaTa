// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Internal.TestSupport.__IFullLiteTestStructureFactory
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

#nullable disable
namespace Yandex.Runtime.Internal.TestSupport
{
  [Guid(1407741390, 14218, 13799, 182, 33, 80, 48, 240, 128, 158, 190)]
  [ExclusiveTo(typeof (FullLiteTestStructure))]
  [Version(1)]
  [WebHostHidden]
  internal interface __IFullLiteTestStructureFactory
  {
    [Overload("CreateInstance1")]
    FullLiteTestStructure CreateInstance(
      [In] bool b,
      [In] IReference<bool> ob,
      [In] int i,
      [In] IReference<int> oi,
      [In] uint ui,
      [In] IReference<uint> oui,
      [In] long i64,
      [In] IReference<long> oi64,
      [In] float fl,
      [In] IReference<float> ofl,
      [In] double d,
      [In] IReference<double> od,
      [In] string s,
      [In] string os,
      [In] TimeSpan ti,
      [In] IReference<TimeSpan> oti,
      [In] DateTime at,
      [In] IReference<DateTime> oat,
      [In] DateTime rt,
      [In] IReference<DateTime> ort,
      [In] byte[] by,
      [In] byte[] oby,
      [In] Color c,
      [In] IReference<Color> oc,
      [In] Point p,
      [In] IReference<Point> op,
      [In] TestEnum e,
      [In] IReference<TestEnum> oe,
      [In] TestBitfieldEnum be,
      [In] IReference<TestBitfieldEnum> obe);
  }
}
