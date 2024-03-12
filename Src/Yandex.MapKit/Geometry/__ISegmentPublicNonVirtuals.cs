// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.__ISegmentPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Geometry
{
  [ExclusiveTo(typeof (Segment))]
  [WebHostHidden]
  [Guid(2151696883, 36944, 13160, 145, 32, 146, 121, 78, 234, 172, 103)]
  [Version(1)]
  internal interface __ISegmentPublicNonVirtuals
  {
    Point StartPoint { get; }

    Point EndPoint { get; }
  }
}
