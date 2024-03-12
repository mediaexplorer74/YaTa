// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Runtime
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime
{
  [Threading]
  [global::Windows.Foundation.Metadata.Version(1)]
  [MarshalingBehavior]
  [Static(typeof (__IRuntimeStatics), 1)]
  [Activatable(1)]
  [WebHostHidden]
  public sealed class Runtime : __IRuntimePublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern string Version();

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern void SetFailedAssertionListener([In] OnFailedAssertion onFailedAssertion);

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern void Deinitialize();

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Runtime();
  }
}
