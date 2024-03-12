// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.DiskWriteAccessError
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime
{
  [Version(1)]
  [WebHostHidden]
  [Guid(2658464795, 52724, 14528, 133, 217, 237, 83, 221, 243, 53, 48)]
  public interface DiskWriteAccessError : Error, LocalError, DiskCorruptError
  {
  }
}
