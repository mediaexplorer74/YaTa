// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Internal.TestSupport.__ITestStructureFactory
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime.Internal.TestSupport
{
  [Guid(3772261827, 14114, 13261, 173, 244, 255, 58, 123, 196, 113, 89)]
  [Version(1)]
  [ExclusiveTo(typeof (TestStructure))]
  [WebHostHidden]
  internal interface __ITestStructureFactory
  {
    [Overload("CreateInstance1")]
    TestStructure CreateInstance(
      [In] bool b,
      [In] string text,
      [In] string optionalText,
      [In] IVectorView<int> intVector,
      [In] TimeSpan interval,
      [In] DateTime timestamp);
  }
}
