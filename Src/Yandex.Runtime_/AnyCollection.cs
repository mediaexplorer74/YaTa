// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.AnyCollection
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime
{
  [Version(1)]
  [MarshalingBehavior]
  [Threading]
  [WebHostHidden]
  public sealed class AnyCollection : __IAnyCollectionPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern object GetItem([In] string nativeName);
  }
}
