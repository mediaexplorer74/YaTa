// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.__IGuidancePhraseFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [WebHostHidden]
  [ExclusiveTo(typeof (GuidancePhrase))]
  [Guid(3504258176, 7620, 14615, 146, 149, 124, 37, 96, 24, 200, 124)]
  [Version(1)]
  internal interface __IGuidancePhraseFactory
  {
    [Overload("CreateInstance1")]
    GuidancePhrase CreateInstance([In] IVectorView<GuidancePhrasePart> parts);
  }
}
