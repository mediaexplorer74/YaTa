// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.Internal.RawConstruction
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Masstransit.Internal
{
  [WebHostHidden]
  [MarshalingBehavior]
  [Version(1)]
  [Activatable(typeof (__IRawConstructionFactory), 1)]
  [Static(typeof (__IRawConstructionStatics), 1)]
  [Threading]
  public sealed class RawConstruction : __IRawConstructionPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern RawConstruction From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern RawConstruction([In] PedestrianConstructionID construction_id, [In] int count);

    public extern PedestrianConstructionID Construction_id { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern int Count { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
