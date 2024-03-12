// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Internal.TestSupport.__IOptionsTestStructureFactory
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime.Internal.TestSupport
{
  [Version(1)]
  [Guid(805802871, 18477, 13767, 153, 20, 147, 39, 229, 113, 223, 163)]
  [ExclusiveTo(typeof (OptionsTestStructure))]
  [WebHostHidden]
  internal interface __IOptionsTestStructureFactory
  {
    [Overload("CreateInstance1")]
    OptionsTestStructure CreateInstance(
      [In] IReference<bool> b,
      [In] string text,
      [In] IReference<TimeSpan> interval,
      [In] IReference<DateTime> timestamp);
  }
}
