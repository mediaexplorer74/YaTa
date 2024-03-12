// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Internal.TestSupport.__ILiteTestStructureFactory
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime.Internal.TestSupport
{
  [ExclusiveTo(typeof (LiteTestStructure))]
  [Version(1)]
  [WebHostHidden]
  [Guid(1783394647, 46218, 14286, 138, 75, 192, 120, 142, 28, 83, 16)]
  internal interface __ILiteTestStructureFactory
  {
    [Overload("CreateInstance1")]
    LiteTestStructure CreateInstance(
      [In] bool b,
      [In] string text,
      [In] string optionalText,
      [In] TimeSpan interval,
      [In] DateTime timestamp);
  }
}
