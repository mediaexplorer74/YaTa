// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.Snippet
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Flags]
  [Version(1)]
  public enum Snippet : uint
  {
    None = 0,
    Photos = 1,
    BusinessRating = 2,
    BusinessList = 4,
    Router = 8,
    Panoramas = 16, // 0x00000010
    MassTransit = 32, // 0x00000020
  }
}
