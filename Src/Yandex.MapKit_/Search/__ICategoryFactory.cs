// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__ICategoryFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Version(1)]
  [WebHostHidden]
  [Guid(1239827300, 13412, 12483, 171, 34, 223, 109, 168, 129, 145, 157)]
  [ExclusiveTo(typeof (Category))]
  internal interface __ICategoryFactory
  {
    [Overload("CreateInstance1")]
    Category CreateInstance([In] string name, [In] string categoryClass);
  }
}
