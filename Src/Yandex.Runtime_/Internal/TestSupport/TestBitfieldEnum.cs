// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Internal.TestSupport.TestBitfieldEnum
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using System;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime.Internal.TestSupport
{
  [Flags]
  [Version(1)]
  public enum TestBitfieldEnum : uint
  {
    One = 1,
    Two = 2,
    Four = 4,
    Eight = 8,
  }
}
