// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Reviews.__ITagFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Reviews
{
  [Guid(2220962966, 11769, 15316, 189, 165, 34, 132, 109, 39, 40, 135)]
  [ExclusiveTo(typeof (Tag))]
  [WebHostHidden]
  [Version(1)]
  internal interface __ITagFactory
  {
    [Overload("CreateInstance1")]
    Tag CreateInstance([In] string name, [In] int value, [In] string caption);
  }
}
