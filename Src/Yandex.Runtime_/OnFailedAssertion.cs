// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.OnFailedAssertion
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime
{
  [WebHostHidden]
  [Version(1)]
  [Guid(2582205632, 65096, 15367, 137, 12, 160, 157, 230, 78, 230, 103)]
  public delegate void OnFailedAssertion(
    [In] string file,
    [In] int line,
    [In] string condition,
    [In] string message,
    [In] IVectorView<string> stack);
}
