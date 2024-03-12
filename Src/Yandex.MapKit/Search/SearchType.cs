// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.SearchType
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Version(1)]
  [Flags]
  public enum SearchType : uint
  {
    None = 0,
    Geo = 1,
    Biz = 2,
    Psearch = 4,
    Web = 8,
    Transit = 16, // 0x00000010
  }
}
