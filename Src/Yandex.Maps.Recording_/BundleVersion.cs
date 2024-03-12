// Decompiled with JetBrains decompiler
// Type: Yandex.Maps.Recording.BundleVersion
// Assembly: Yandex.Maps.Recording, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 50EEDF86-9D89-467B-BD6C-212DF28AA2C9
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Maps.Recording.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Maps.Recording
{
  [Static(typeof (__IBundleVersionStatics), 1)]
  [MarshalingBehavior]
  [Version(1)]
  [Activatable(1)]
  [Threading]
  public sealed class BundleVersion : __IBundleVersionPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern string get();

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern BundleVersion();
  }
}
