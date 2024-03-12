// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IPhonePublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Version(1)]
  [Guid(384504104, 34245, 15153, 191, 27, 27, 229, 11, 171, 245, 79)]
  [ExclusiveTo(typeof (Phone))]
  [WebHostHidden]
  internal interface __IPhonePublicNonVirtuals
  {
    PhoneType Type { get; }

    string FormattedNumber { get; }

    string Info { get; }

    IReference<uint> Country { get; }

    IReference<uint> Prefix { get; }

    IReference<uint> Ext { get; }

    uint Number { get; }
  }
}
