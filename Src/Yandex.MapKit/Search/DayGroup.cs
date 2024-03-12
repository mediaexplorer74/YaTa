// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.DayGroup
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
  public enum DayGroup : uint
  {
    None = 0,
    Sunday = 1,
    Monday = 2,
    Tuesday = 4,
    Wednesday = 8,
    Thursday = 16, // 0x00000010
    Friday = 32, // 0x00000020
    Saturday = 64, // 0x00000040
    Weekdays = Friday | Thursday | Wednesday | Tuesday | Monday, // 0x0000003E
    Weekend = Saturday | Sunday, // 0x00000041
    Everyday = Weekend | Weekdays, // 0x0000007F
  }
}
