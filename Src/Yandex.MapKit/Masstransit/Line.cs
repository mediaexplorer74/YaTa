// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.Line
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Static(typeof (__ILineStatics), 1)]
  [MarshalingBehavior]
  [Threading]
  [WebHostHidden]
  [Activatable(typeof (__ILineFactory), 1)]
  [Version(1)]
  public sealed class Line : __ILinePublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern Line From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Line([In] string id, [In] string name, [In] IVectorView<Type> vehicleTypes, [In] LineStyle style);

    public extern string Id { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Name { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<Type> VehicleTypes { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern LineStyle Style { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
