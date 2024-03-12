// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Internal.TestSupport.__ITestStructurePublicNonVirtuals
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime.Internal.TestSupport
{
  [WebHostHidden]
  [Version(1)]
  [Guid(3569429903, 26444, 15303, 178, 226, 216, 182, 100, 178, 148, 250)]
  [ExclusiveTo(typeof (TestStructure))]
  internal interface __ITestStructurePublicNonVirtuals
  {
    bool B { get; }

    string Text { get; }

    string OptionalText { get; }

    IVectorView<int> IntVector { get; }

    TimeSpan Interval { get; }

    DateTime Timestamp { get; }
  }
}
