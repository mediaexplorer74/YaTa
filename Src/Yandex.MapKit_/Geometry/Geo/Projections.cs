// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.Geo.Projections
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Geometry.Geo
{
  [Activatable(1)]
  [MarshalingBehavior]
  [WebHostHidden]
  [Threading]
  [Version(1)]
  [Static(typeof (__IProjectionsStatics), 1)]
  public sealed class Projections : __IProjectionsPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern Projection CreateWgs84Mercator();

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Projections();
  }
}
