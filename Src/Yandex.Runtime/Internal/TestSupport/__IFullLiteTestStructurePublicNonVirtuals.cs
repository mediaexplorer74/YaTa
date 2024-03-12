// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Internal.TestSupport.__IFullLiteTestStructurePublicNonVirtuals
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

#nullable disable
namespace Yandex.Runtime.Internal.TestSupport
{
  [WebHostHidden]
  [Version(1)]
  [Guid(2856095450, 41951, 13150, 128, 224, 182, 178, 231, 128, 100, 63)]
  [ExclusiveTo(typeof (FullLiteTestStructure))]
  internal interface __IFullLiteTestStructurePublicNonVirtuals
  {
    bool B { get; }

    IReference<bool> Ob { get; }

    int I { get; }

    IReference<int> Oi { get; }

    uint Ui { get; }

    IReference<uint> Oui { get; }

    long I64 { get; }

    IReference<long> Oi64 { get; }

    float Fl { get; }

    IReference<float> Ofl { get; }

    double D { get; }

    IReference<double> Od { get; }

    string S { get; }

    string Os { get; }

    TimeSpan Ti { get; }

    IReference<TimeSpan> Oti { get; }

    DateTime At { get; }

    IReference<DateTime> Oat { get; }

    DateTime Rt { get; }

    IReference<DateTime> Ort { get; }

    byte[] By { get; }

    byte[] Oby { get; }

    Color C { get; }

    IReference<Color> Oc { get; }

    Point P { get; }

    IReference<Point> Op { get; }

    TestEnum E { get; }

    IReference<TestEnum> Oe { get; }

    TestBitfieldEnum Be { get; }

    IReference<TestBitfieldEnum> Obe { get; }
  }
}
