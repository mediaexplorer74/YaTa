// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Internal.TestSupport.__IFullTestStructurePublicNonVirtuals
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI;

#nullable disable
namespace Yandex.Runtime.Internal.TestSupport
{
  [Version(1)]
  [Guid(3593729848, 25981, 14068, 187, 243, 84, 71, 139, 51, 166, 51)]
  [ExclusiveTo(typeof (FullTestStructure))]
  [WebHostHidden]
  internal interface __IFullTestStructurePublicNonVirtuals
  {
    bool B { get; }

    IReference<bool> Ob { get; }

    IVectorView<bool> Vb { get; }

    IVectorView<IReference<bool>> Vob { get; }

    IMapView<string, bool> Db { get; }

    IMapView<string, IReference<bool>> Dob { get; }

    int I { get; }

    IReference<int> Oi { get; }

    IVectorView<bool> Vi { get; }

    IVectorView<IReference<bool>> Voi { get; }

    IMapView<string, bool> Di { get; }

    IMapView<string, IReference<bool>> Doi { get; }

    uint Ui { get; }

    IReference<uint> Oui { get; }

    IVectorView<bool> Vui { get; }

    IVectorView<IReference<bool>> Voui { get; }

    IMapView<string, bool> Dui { get; }

    IMapView<string, IReference<bool>> Doui { get; }

    long I64 { get; }

    IReference<long> Oi64 { get; }

    IVectorView<bool> Vi64 { get; }

    IVectorView<IReference<bool>> Voi64 { get; }

    IMapView<string, bool> Di64 { get; }

    IMapView<string, IReference<bool>> Doi64 { get; }

    float Fl { get; }

    IReference<float> Ofl { get; }

    IVectorView<bool> Vfl { get; }

    IVectorView<IReference<bool>> Vofl { get; }

    IMapView<string, bool> Dfl { get; }

    IMapView<string, IReference<bool>> Dofl { get; }

    double D { get; }

    IReference<double> Od { get; }

    IVectorView<bool> Vd { get; }

    IVectorView<IReference<bool>> Vod { get; }

    IMapView<string, bool> Dd { get; }

    IMapView<string, IReference<bool>> Dod { get; }

    string S { get; }

    string Os { get; }

    IVectorView<bool> Vs { get; }

    IVectorView<IReference<bool>> Vos { get; }

    IMapView<string, bool> Ds { get; }

    IMapView<string, IReference<bool>> Dos { get; }

    TimeSpan Ti { get; }

    IReference<TimeSpan> Oti { get; }

    IVectorView<bool> Vti { get; }

    IVectorView<IReference<bool>> Voti { get; }

    IMapView<string, bool> Dti { get; }

    IMapView<string, IReference<bool>> Doti { get; }

    DateTime At { get; }

    IReference<DateTime> Oat { get; }

    IVectorView<bool> Vat { get; }

    IVectorView<IReference<bool>> Voat { get; }

    IMapView<string, bool> Dat { get; }

    IMapView<string, IReference<bool>> Doat { get; }

    DateTime Rt { get; }

    IReference<DateTime> Ort { get; }

    IVectorView<bool> Vrt { get; }

    IVectorView<IReference<bool>> Vort { get; }

    IMapView<string, bool> Drt { get; }

    IMapView<string, IReference<bool>> Dort { get; }

    byte[] By { get; }

    byte[] Oby { get; }

    Color C { get; }

    IReference<Color> Oc { get; }

    IVectorView<Color> Vc { get; }

    IVectorView<IReference<Color>> Voc { get; }

    IMapView<string, Color> Dc { get; }

    IMapView<string, IReference<Color>> Doc { get; }

    Point P { get; }

    IReference<Point> Op { get; }

    IVectorView<Point> Vp { get; }

    IVectorView<IReference<Point>> Vop { get; }

    IMapView<string, Point> Dp { get; }

    IMapView<string, IReference<Point>> Dop { get; }

    TestEnum E { get; }

    IReference<TestEnum> Oe { get; }

    IVectorView<TestEnum> Ve { get; }

    IVectorView<IReference<TestEnum>> Voe { get; }

    IMapView<string, TestEnum> De { get; }

    IMapView<string, IReference<TestEnum>> Doe { get; }

    TestBitfieldEnum Be { get; }

    IReference<TestBitfieldEnum> Obe { get; }

    IVectorView<TestBitfieldEnum> Vbe { get; }

    IVectorView<IReference<TestBitfieldEnum>> Vobe { get; }

    IMapView<string, TestBitfieldEnum> Dbe { get; }

    IMapView<string, IReference<TestBitfieldEnum>> Dobe { get; }

    TestStructure Ts { get; }

    TestStructure Ots { get; }

    IVectorView<TestStructure> Vts { get; }

    IVectorView<TestStructure> Vots { get; }

    IMapView<string, TestStructure> Dts { get; }

    IMapView<string, TestStructure> Dots { get; }

    LiteTestStructure Lts { get; }

    LiteTestStructure Olts { get; }

    IVectorView<LiteTestStructure> Vlts { get; }

    IVectorView<LiteTestStructure> Volts { get; }

    IMapView<string, LiteTestStructure> Dlts { get; }

    IMapView<string, LiteTestStructure> Dolts { get; }

    OptionsTestStructure Opts { get; }

    OptionsTestStructure Oopts { get; }

    IVectorView<OptionsTestStructure> Vopts { get; }

    IVectorView<OptionsTestStructure> Voopts { get; }

    IMapView<string, OptionsTestStructure> Dopts { get; }

    IMapView<string, OptionsTestStructure> Doopts { get; }
  }
}
