// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.__IFasterAlternativeFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [ExclusiveTo(typeof (FasterAlternative))]
  [Version(1)]
  [WebHostHidden]
  [Guid(792035669, 52968, 14114, 141, 189, 184, 150, 53, 130, 159, 42)]
  internal interface __IFasterAlternativeFactory
  {
    [Overload("CreateInstance1")]
    FasterAlternative CreateInstance([In] LocalizedValue timeDifference);
  }
}
