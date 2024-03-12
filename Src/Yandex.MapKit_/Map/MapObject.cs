// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Map.MapObject
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Map
{
  [Version(1)]
  [WebHostHidden]
  [Guid(3798936707, 3446, 16319, 158, 25, 8, 57, 44, 48, 19, 14)]
  public interface MapObject
  {
    MapObjectCollection Parent { get; }

    bool Visible { get; [param: In] set; }

    void SetVisible([In] bool visible, [In] bool animate);

    float ZIndex { get; [param: In] set; }

    bool Draggable { get; [param: In] set; }

    object UserData { get; [param: In] set; }

    void AddTapListener([In] MapObjectTapListener tapListener);

    void RemoveTapListener([In] MapObjectTapListener tapListener);

    void SetDragListener([In] MapObjectDragListener dragListener);

    bool Valid { get; }
  }
}
