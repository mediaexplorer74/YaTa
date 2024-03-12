// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.__IAnyCollectionPublicNonVirtuals
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime
{
  [ExclusiveTo(typeof (AnyCollection))]
  [Version(1)]
  [Guid(3275342154, 37778, 15033, 147, 111, 128, 207, 172, 69, 103, 233)]
  [WebHostHidden]
  internal interface __IAnyCollectionPublicNonVirtuals
  {
    object GetItem([In] string nativeName);
  }
}
