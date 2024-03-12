// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Internal.TestSupport.FullTestStructure
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI;

#nullable disable
namespace Yandex.Runtime.Internal.TestSupport
{
  [Threading]
  [Version(1)]
  [Static(typeof (__IFullTestStructureStatics), 1)]
  [Activatable(typeof (__IFullTestStructureFactory), 1)]
  [MarshalingBehavior]
  [WebHostHidden]
  public sealed class FullTestStructure : __IFullTestStructurePublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern FullTestStructure From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern FullTestStructure(
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

    public extern bool B { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<bool> Ob { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<bool> Vb { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<IReference<bool>> Vob { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IMapView<string, bool> Db { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IMapView<string, IReference<bool>> Dob { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern int I { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<int> Oi { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<bool> Vi { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<IReference<bool>> Voi { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IMapView<string, bool> Di { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IMapView<string, IReference<bool>> Doi { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern uint Ui { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<uint> Oui { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<bool> Vui { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<IReference<bool>> Voui { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IMapView<string, bool> Dui { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IMapView<string, IReference<bool>> Doui { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern long I64 { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<long> Oi64 { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<bool> Vi64 { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<IReference<bool>> Voi64 { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IMapView<string, bool> Di64 { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IMapView<string, IReference<bool>> Doi64 { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern float Fl { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<float> Ofl { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<bool> Vfl { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<IReference<bool>> Vofl { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IMapView<string, bool> Dfl { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IMapView<string, IReference<bool>> Dofl { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern double D { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<double> Od { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<bool> Vd { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<IReference<bool>> Vod { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IMapView<string, bool> Dd { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IMapView<string, IReference<bool>> Dod { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string S { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Os { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<bool> Vs { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<IReference<bool>> Vos { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IMapView<string, bool> Ds { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IMapView<string, IReference<bool>> Dos { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern TimeSpan Ti { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<TimeSpan> Oti { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<bool> Vti { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<IReference<bool>> Voti { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IMapView<string, bool> Dti { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IMapView<string, IReference<bool>> Doti { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern DateTime At { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<DateTime> Oat { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<bool> Vat { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<IReference<bool>> Voat { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IMapView<string, bool> Dat { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IMapView<string, IReference<bool>> Doat { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern DateTime Rt { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<DateTime> Ort { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<bool> Vrt { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<IReference<bool>> Vort { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IMapView<string, bool> Drt { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IMapView<string, IReference<bool>> Dort { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern byte[] By { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern byte[] Oby { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern Color C { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<Color> Oc { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<Color> Vc { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<IReference<Color>> Voc { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IMapView<string, Color> Dc { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IMapView<string, IReference<Color>> Doc { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern Point P { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<Point> Op { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<Point> Vp { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<IReference<Point>> Vop { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IMapView<string, Point> Dp { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IMapView<string, IReference<Point>> Dop { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern TestEnum E { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<TestEnum> Oe { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<TestEnum> Ve { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<IReference<TestEnum>> Voe { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IMapView<string, TestEnum> De { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IMapView<string, IReference<TestEnum>> Doe { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern TestBitfieldEnum Be { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<TestBitfieldEnum> Obe { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<TestBitfieldEnum> Vbe { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<IReference<TestBitfieldEnum>> Vobe { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IMapView<string, TestBitfieldEnum> Dbe { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IMapView<string, IReference<TestBitfieldEnum>> Dobe { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern TestStructure Ts { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern TestStructure Ots { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<TestStructure> Vts { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<TestStructure> Vots { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IMapView<string, TestStructure> Dts { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IMapView<string, TestStructure> Dots { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern LiteTestStructure Lts { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern LiteTestStructure Olts { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<LiteTestStructure> Vlts { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<LiteTestStructure> Volts { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IMapView<string, LiteTestStructure> Dlts { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IMapView<string, LiteTestStructure> Dolts { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern OptionsTestStructure Opts { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern OptionsTestStructure Oopts { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<OptionsTestStructure> Vopts { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<OptionsTestStructure> Voopts { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IMapView<string, OptionsTestStructure> Dopts { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IMapView<string, OptionsTestStructure> Doopts { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
