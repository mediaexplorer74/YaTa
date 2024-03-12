// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Internal.TestSupport.__IFullTestStructureStatics
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime.Internal.TestSupport
{
  [WebHostHidden]
  [Guid(4253628855, 10042, 12688, 146, 75, 202, 182, 49, 184, 168, 202)]
  [ExclusiveTo(typeof (FullTestStructure))]
  [Version(1)]
  internal interface __IFullTestStructureStatics
  {
    FullTestStructure From([In] AnyCollection anyCollection);
  }
}
