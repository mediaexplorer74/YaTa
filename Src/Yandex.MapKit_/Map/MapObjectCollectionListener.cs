﻿// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Map.MapObjectCollectionListener
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Map
{
  [Version(1)]
  [Guid(1906954120, 21888, 13684, 171, 230, 9, 99, 97, 31, 33, 57)]
  [WebHostHidden]
  public interface MapObjectCollectionListener
  {
    void OnMapObjectAdded([In] MapObject mapObject);

    void OnMapObjectRemoved([In] MapObject mapObject);

    void OnMapObjectUpdated([In] MapObject mapObject);
  }
}
