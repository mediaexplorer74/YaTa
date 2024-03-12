// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Internal.TestSupport.__ILiteTestStructurePublicNonVirtuals
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime.Internal.TestSupport
{
  [WebHostHidden]
  [ExclusiveTo(typeof (LiteTestStructure))]
  [Version(1)]
  [Guid(2213607264, 59458, 12666, 188, 33, 211, 153, 246, 15, 117, 169)]
  internal interface __ILiteTestStructurePublicNonVirtuals
  {
    bool B { get; }

    string Text { get; }

    string OptionalText { get; }

    TimeSpan Interval { get; }

    DateTime Timestamp { get; }
  }
}
