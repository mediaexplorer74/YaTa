// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.__IRuntimeStatics
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime
{
  [ExclusiveTo(typeof (global::Yandex.Runtime.Runtime))]
  [Guid(2209666820, 42669, 13137, 149, 71, 97, 69, 132, 198, 158, 105)]
  [global::Windows.Foundation.Metadata.Version(1)]
  [WebHostHidden]
  internal interface __IRuntimeStatics
  {
    string Version();

    void SetFailedAssertionListener([In] OnFailedAssertion onFailedAssertion);

    void Deinitialize();
  }
}
