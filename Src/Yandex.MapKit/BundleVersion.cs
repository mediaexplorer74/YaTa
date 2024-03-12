// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.BundleVersion
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit
{
  [Static(typeof (__IBundleVersionStatics), 1)]
  [Version(1)]
  [MarshalingBehavior]
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
