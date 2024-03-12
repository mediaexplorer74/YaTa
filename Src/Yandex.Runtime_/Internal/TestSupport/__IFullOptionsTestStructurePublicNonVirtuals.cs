// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Internal.TestSupport.__IFullOptionsTestStructurePublicNonVirtuals
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
  [Version(1)]
  [Guid(2932291240, 45327, 15387, 145, 182, 4, 92, 209, 93, 66, 68)]
  [ExclusiveTo(typeof (FullOptionsTestStructure))]
  [WebHostHidden]
  internal interface __IFullOptionsTestStructurePublicNonVirtuals
  {
    IReference<bool> B { get; [param: In] set; }

    IReference<int> I { get; [param: In] set; }

    IReference<uint> Ui { get; [param: In] set; }

    IReference<long> I64 { get; [param: In] set; }

    IReference<float> Fl { get; [param: In] set; }

    IReference<double> D { get; [param: In] set; }

    string S { get; [param: In] set; }

    IReference<TimeSpan> Ti { get; [param: In] set; }

    IReference<DateTime> At { get; [param: In] set; }

    IReference<DateTime> Rt { get; [param: In] set; }

    byte[] By { get; [param: In] set; }

    IReference<Color> C { get; [param: In] set; }

    IReference<Point> P { get; [param: In] set; }

    IReference<TestEnum> E { get; [param: In] set; }

    IReference<TestBitfieldEnum> Be { get; [param: In] set; }
  }
}
