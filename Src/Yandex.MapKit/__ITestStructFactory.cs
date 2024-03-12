// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.__ITestStructFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit
{
  [WebHostHidden]
  [Guid(1771920615, 11836, 12387, 187, 87, 27, 174, 211, 253, 227, 219)]
  [ExclusiveTo(typeof (TestStruct))]
  [Version(1)]
  internal interface __ITestStructFactory
  {
    [Overload("CreateInstance1")]
    TestStruct CreateInstance([In] uint value);
  }
}
