// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Internal.TestSupport.__ITestStructureStatics
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime.Internal.TestSupport
{
  [Version(1)]
  [Guid(3454395470, 23859, 15529, 137, 31, 103, 241, 249, 239, 177, 16)]
  [ExclusiveTo(typeof (TestStructure))]
  [WebHostHidden]
  internal interface __ITestStructureStatics
  {
    TestStructure From([In] AnyCollection anyCollection);
  }
}
