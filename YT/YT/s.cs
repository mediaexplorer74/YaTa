using System;
using System.Collections.Generic;
using System.Threading;

using MapController = ru.yandex.yandexmapkit.MapController;
using MapEvent = ru.yandex.yandexmapkit.map.MapEvent;
using OnMapListener = ru.yandex.yandexmapkit.map.OnMapListener;

public class s : ThreadStart
{
  public s(MapController.Map paramMap)
  {
  }

  public virtual void run()
  {
	while (!this.a.f)
	{
	  try
	  {
		object @object = this.a.m;
		/* monitor enter ClassFileLocalVariableReferenceExpression{type=ObjectType{java/lang/Object}, name=null} */
		try
		{
		  MapEvent mapEvent;
		  if (!this.a.l.isEmpty())
		  {
			mapEvent = this.a.l.getFirst();
			this.a.l.remove(mapEvent);
		  }
		  else
		  {
			Monitor.Wait(this.a.m);
			mapEvent = null;
		  }
		  /* monitor exit ClassFileLocalVariableReferenceExpression{type=ObjectType{java/lang/Object}, name=null} */
		  if (mapEvent != null)
		  {
			lock (this.a.k)
			{
			  IEnumerator<OnMapListener> iterator = this.a.k.GetEnumerator();
			  while (iterator.MoveNext())
			  {
				((OnMapListener)iterator.Current).onMapActionEvent(mapEvent);
			  }
			}
			/* monitor exit ClassFileLocalVariableReferenceExpression{type=ObjectType{java/lang/Object}, name=null} */
		  }
		}
		finally
		{
		}
	  }
	  catch (Exception)
	  {
		continue;
	  }
	  /* monitor exit ClassFileLocalVariableReferenceExpression{type=ObjectType{java/lang/Object}, name=SYNTHETIC_LOCAL_VARIABLE_1} */
	  throw exception;
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\s.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */