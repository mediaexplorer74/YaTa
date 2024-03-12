// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.Internal.__IRawSectionMetadataStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Driving.Internal
{
  [Guid(1591219485, 2228, 16202, 140, 108, 73, 23, 30, 164, 181, 106)]
  [ExclusiveTo(typeof (RawSectionMetadata))]
  [Version(1)]
  [WebHostHidden]
  internal interface __IRawSectionMetadataStatics
  {
    RawSectionMetadata From([In] AnyCollection anyCollection);
  }
}
