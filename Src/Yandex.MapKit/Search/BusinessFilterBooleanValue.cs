// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.BusinessFilterBooleanValue
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Activatable(typeof (__IBusinessFilterBooleanValueFactory), 1)]
  [Threading]
  [MarshalingBehavior]
  [WebHostHidden]
  [Version(1)]
  public sealed class BusinessFilterBooleanValue : __IBusinessFilterBooleanValuePublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern BusinessFilterBooleanValue([In] bool value, [In] IReference<bool> selected);

    public extern bool Value { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<bool> Selected { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
