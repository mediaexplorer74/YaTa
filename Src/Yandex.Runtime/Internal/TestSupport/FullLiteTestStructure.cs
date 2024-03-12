// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Internal.TestSupport.FullLiteTestStructure
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

#nullable disable
namespace Yandex.Runtime.Internal.TestSupport
{
  [WebHostHidden]
  [Threading]
  [Activatable(typeof (__IFullLiteTestStructureFactory), 1)]
  [MarshalingBehavior]
  [Version(1)]
  public sealed class FullLiteTestStructure : __IFullLiteTestStructurePublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern FullLiteTestStructure(
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

    public extern bool B { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<bool> Ob { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern int I { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<int> Oi { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern uint Ui { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<uint> Oui { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern long I64 { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<long> Oi64 { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern float Fl { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<float> Ofl { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern double D { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<double> Od { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string S { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Os { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern TimeSpan Ti { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<TimeSpan> Oti { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern DateTime At { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<DateTime> Oat { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern DateTime Rt { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<DateTime> Ort { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern byte[] By { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern byte[] Oby { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern Color C { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<Color> Oc { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern Point P { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<Point> Op { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern TestEnum E { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<TestEnum> Oe { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern TestBitfieldEnum Be { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<TestBitfieldEnum> Obe { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
