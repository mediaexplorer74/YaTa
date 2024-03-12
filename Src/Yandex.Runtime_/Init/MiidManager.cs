// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Init.MiidManager
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime.Init
{
  [Version(1)]
  [WebHostHidden]
  [Guid(710187716, 39585, 13866, 157, 217, 167, 162, 191, 166, 144, 166)]
  public interface MiidManager
  {
    void Submit([In] OnMiidReceived onMiidReceived, [In] OnMiidError onMiidError);

    bool Valid { get; }
  }
}
