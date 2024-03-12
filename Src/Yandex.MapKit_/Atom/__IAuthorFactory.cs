// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Atom.__IAuthorFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Atom
{
  [Guid(1995658665, 47291, 12760, 156, 70, 169, 98, 84, 173, 35, 8)]
  [ExclusiveTo(typeof (Author))]
  [Version(1)]
  [WebHostHidden]
  internal interface __IAuthorFactory
  {
    [Overload("CreateInstance1")]
    Author CreateInstance([In] string name, [In] string uri, [In] string email);
  }
}
