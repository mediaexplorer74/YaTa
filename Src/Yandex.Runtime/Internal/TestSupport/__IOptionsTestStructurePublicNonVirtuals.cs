// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Internal.TestSupport.__IOptionsTestStructurePublicNonVirtuals
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime.Internal.TestSupport
{
  [ExclusiveTo(typeof (OptionsTestStructure))]
  [Version(1)]
  [Guid(3771035304, 26205, 12958, 132, 59, 10, 173, 219, 120, 144, 129)]
  [WebHostHidden]
  internal interface __IOptionsTestStructurePublicNonVirtuals
  {
    IReference<bool> B { get; [param: In] set; }

    string Text { get; [param: In] set; }

    IReference<TimeSpan> Interval { get; [param: In] set; }

    IReference<DateTime> Timestamp { get; [param: In] set; }
  }
}
