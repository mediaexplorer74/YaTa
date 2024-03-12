// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Internal.TestSupport.__IFullOptionsTestStructureFactory
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
  [WebHostHidden]
  [Guid(2209195378, 23251, 14313, 182, 172, 181, 54, 24, 243, 96, 3)]
  [Version(1)]
  [ExclusiveTo(typeof (FullOptionsTestStructure))]
  internal interface __IFullOptionsTestStructureFactory
  {
    [Overload("CreateInstance1")]
    FullOptionsTestStructure CreateInstance(
      [In] IReference<bool> b,
      [In] IReference<int> i,
      [In] IReference<uint> ui,
      [In] IReference<long> i64,
      [In] IReference<float> fl,
      [In] IReference<double> d,
      [In] string s,
      [In] IReference<TimeSpan> ti,
      [In] IReference<DateTime> at,
      [In] IReference<DateTime> rt,
      [In] byte[] by,
      [In] IReference<Color> c,
      [In] IReference<Point> p,
      [In] IReference<TestEnum> e,
      [In] IReference<TestBitfieldEnum> be);
  }
}
