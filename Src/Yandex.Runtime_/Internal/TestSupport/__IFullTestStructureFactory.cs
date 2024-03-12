// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Internal.TestSupport.__IFullTestStructureFactory
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI;

#nullable disable
namespace Yandex.Runtime.Internal.TestSupport
{
  [WebHostHidden]
  [Guid(1303052065, 42730, 14086, 138, 111, 211, 247, 226, 173, 25, 117)]
  [Version(1)]
  [ExclusiveTo(typeof (FullTestStructure))]
  internal interface __IFullTestStructureFactory
  {
    [Overload("CreateInstance1")]
    FullTestStructure CreateInstance(
      [In] bool b,
      [In] IReference<bool> ob,
      [In] IVectorView<bool> vb,
      [In] IVectorView<IReference<bool>> vob,
      [In] IMapView<string, bool> db,
      [In] IMapView<string, IReference<bool>> dob,
      [In] int i,
      [In] IReference<int> oi,
      [In] IVectorView<bool> vi,
      [In] IVectorView<IReference<bool>> voi,
      [In] IMapView<string, bool> di,
      [In] IMapView<string, IReference<bool>> doi,
      [In] uint ui,
      [In] IReference<uint> oui,
      [In] IVectorView<bool> vui,
      [In] IVectorView<IReference<bool>> voui,
      [In] IMapView<string, bool> dui,
      [In] IMapView<string, IReference<bool>> doui,
      [In] long i64,
      [In] IReference<long> oi64,
      [In] IVectorView<bool> vi64,
      [In] IVectorView<IReference<bool>> voi64,
      [In] IMapView<string, bool> di64,
      [In] IMapView<string, IReference<bool>> doi64,
      [In] float fl,
      [In] IReference<float> ofl,
      [In] IVectorView<bool> vfl,
      [In] IVectorView<IReference<bool>> vofl,
      [In] IMapView<string, bool> dfl,
      [In] IMapView<string, IReference<bool>> dofl,
      [In] double d,
      [In] IReference<double> od,
      [In] IVectorView<bool> vd,
      [In] IVectorView<IReference<bool>> vod,
      [In] IMapView<string, bool> dd,
      [In] IMapView<string, IReference<bool>> dod,
      [In] string s,
      [In] string os,
      [In] IVectorView<bool> vs,
      [In] IVectorView<IReference<bool>> vos,
      [In] IMapView<string, bool> ds,
      [In] IMapView<string, IReference<bool>> dos,
      [In] TimeSpan ti,
      [In] IReference<TimeSpan> oti,
      [In] IVectorView<bool> vti,
      [In] IVectorView<IReference<bool>> voti,
      [In] IMapView<string, bool> dti,
      [In] IMapView<string, IReference<bool>> doti,
      [In] DateTime at,
      [In] IReference<DateTime> oat,
      [In] IVectorView<bool> vat,
      [In] IVectorView<IReference<bool>> voat,
      [In] IMapView<string, bool> dat,
      [In] IMapView<string, IReference<bool>> doat,
      [In] DateTime rt,
      [In] IReference<DateTime> ort,
      [In] IVectorView<bool> vrt,
      [In] IVectorView<IReference<bool>> vort,
      [In] IMapView<string, bool> drt,
      [In] IMapView<string, IReference<bool>> dort,
      [In] byte[] by,
      [In] byte[] oby,
      [In] Color c,
      [In] IReference<Color> oc,
      [In] IVectorView<Color> vc,
      [In] IVectorView<IReference<Color>> voc,
      [In] IMapView<string, Color> dc,
      [In] IMapView<string, IReference<Color>> doc,
      [In] Point p,
      [In] IReference<Point> op,
      [In] IVectorView<Point> vp,
      [In] IVectorView<IReference<Point>> vop,
      [In] IMapView<string, Point> dp,
      [In] IMapView<string, IReference<Point>> dop,
      [In] TestEnum e,
      [In] IReference<TestEnum> oe,
      [In] IVectorView<TestEnum> ve,
      [In] IVectorView<IReference<TestEnum>> voe,
      [In] IMapView<string, TestEnum> de,
      [In] IMapView<string, IReference<TestEnum>> doe,
      [In] TestBitfieldEnum be,
      [In] IReference<TestBitfieldEnum> obe,
      [In] IVectorView<TestBitfieldEnum> vbe,
      [In] IVectorView<IReference<TestBitfieldEnum>> vobe,
      [In] IMapView<string, TestBitfieldEnum> dbe,
      [In] IMapView<string, IReference<TestBitfieldEnum>> dobe,
      [In] TestStructure ts,
      [In] TestStructure ots,
      [In] IVectorView<TestStructure> vts,
      [In] IVectorView<TestStructure> vots,
      [In] IMapView<string, TestStructure> dts,
      [In] IMapView<string, TestStructure> dots,
      [In] LiteTestStructure lts,
      [In] LiteTestStructure olts,
      [In] IVectorView<LiteTestStructure> vlts,
      [In] IVectorView<LiteTestStructure> volts,
      [In] IMapView<string, LiteTestStructure> dlts,
      [In] IMapView<string, LiteTestStructure> dolts,
      [In] OptionsTestStructure opts,
      [In] OptionsTestStructure oopts,
      [In] IVectorView<OptionsTestStructure> vopts,
      [In] IVectorView<OptionsTestStructure> voopts,
      [In] IMapView<string, OptionsTestStructure> dopts,
      [In] IMapView<string, OptionsTestStructure> doopts);
  }
}
