using System;
using System.Collections;
using System.Threading;

using DownloadJob = ru.yandex.yandexmapkit.net.DownloadJob;
using Downloader = ru.yandex.yandexmapkit.net.Downloader;

public sealed class bh : ThreadStart
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private bool a_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private Downloader b_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private readonly ArrayList c_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private bool d_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private Thread e_Conflict;

  public bh(Downloader paramDownloader)
  {
	bool @bool;
	this.b_Conflict = paramDownloader;
	this.c_Conflict = new ArrayList();
	if (Downloader.d() != null)
	{
	  @bool = true;
	}
	else
	{
	  @bool = false;
	}
	this.d_Conflict = @bool;
  }

  private DownloadJob d()
  {
	// Byte code:
	//   0: aload_0
	//   1: getfield c : Ljava/util/ArrayList;
	//   4: astore_1
	//   5: aload_1
	//   6: monitorenter
	//   7: invokestatic currentTimeMillis : ()J
	//   10: lstore_2
	//   11: aload_0
	//   12: getfield c : Ljava/util/ArrayList;
	//   15: invokevirtual isEmpty : ()Z
	//   18: ifeq -> 29
	//   21: aload_1
	//   22: monitorexit
	//   23: aconst_null
	//   24: astore #4
	//   26: aload #4
	//   28: areturn
	//   29: aload_0
	//   30: getfield d : Z
	//   33: ifne -> 99
	//   36: aload_0
	//   37: getfield c : Ljava/util/ArrayList;
	//   40: invokevirtual iterator : ()Ljava/util/Iterator;
	//   43: astore #5
	//   45: aload #5
	//   47: invokeinterface hasNext : ()Z
	//   52: ifeq -> 153
	//   55: aload #5
	//   57: invokeinterface next : ()Ljava/lang/Object;
	//   62: checkcast ru/yandex/yandexmapkit/net/DownloadJob
	//   65: astore #4
	//   67: aload #4
	//   69: getfield a : I
	//   72: ldc -2147483648
	//   74: if_icmpne -> 45
	//   77: aload #4
	//   79: getfield j : J
	//   82: lload_2
	//   83: lcmp
	//   84: ifge -> 45
	//   87: aload_1
	//   88: monitorexit
	//   89: goto -> 26
	//   92: astore #4
	//   94: aload_1
	//   95: monitorexit
	//   96: aload #4
	//   98: athrow
	//   99: aload_0
	//   100: getfield c : Ljava/util/ArrayList;
	//   103: invokevirtual size : ()I
	//   106: istore #6
	//   108: iconst_0
	//   109: istore #7
	//   111: iload #7
	//   113: iload #6
	//   115: if_icmpge -> 153
	//   118: aload_0
	//   119: getfield c : Ljava/util/ArrayList;
	//   122: iload #7
	//   124: invokevirtual get : (I)Ljava/lang/Object;
	//   127: checkcast ru/yandex/yandexmapkit/net/DownloadJob
	//   130: astore #4
	//   132: aload #4
	//   134: getfield j : J
	//   137: lload_2
	//   138: lcmp
	//   139: ifge -> 147
	//   142: aload_1
	//   143: monitorexit
	//   144: goto -> 26
	//   147: iinc #7, 1
	//   150: goto -> 111
	//   153: aload_1
	//   154: monitorexit
	//   155: aconst_null
	//   156: astore #4
	//   158: goto -> 26
	// Exception table:
	//   from	to	target	type
	//   7	23	92	finally
	//   29	45	92	finally
	//   45	89	92	finally
	//   99	108	92	finally
	//   118	144	92	finally
  }

  private bool e()
  {
	lock (this.c_Conflict)
	{
	  if (d() != null)
	  {
		return true;
	  }
	  return false;
	}
  }

  public void a()
  {
	this.a_Conflict = false;
  }

  public void a(DownloadJob paramDownloadJob)
  {
	if (!this.a_Conflict)
	{
	  lock (this.c_Conflict)
	  {
		if (paramDownloadJob.a_Conflict == int.MinValue)
		{
		  this.d_Conflict = false;
		}
		if (this.c_Conflict.Contains(paramDownloadJob) && !paramDownloadJob.a())
		{
		  this.c_Conflict.Remove(paramDownloadJob);
		}
		paramDownloadJob.j = 0L;
		if (paramDownloadJob.Priority == 1)
		{
		  this.c_Conflict.Insert(0, paramDownloadJob);
		}
		else
		{
		  this.c_Conflict.Add(paramDownloadJob);
		}
		if (this.e_Conflict == null || !this.e_Conflict.IsAlive)
		{
		  Thread thread = new Thread();
		  this(this);
		  this.e_Conflict = thread;
		  this.e_Conflict.setName("ymm-downloader-data");
		  this.e_Conflict.Start();
		}
		else
		{
		  Monitor.PulseAll(this.c_Conflict);
		}
		return;
	  }
	}
  }

  public void b()
  {
	this.a_Conflict = true;
	lock (this.c_Conflict)
	{
	  this.c_Conflict.Clear();
	  Monitor.PulseAll(this.c_Conflict);
	  return;
	}
  }

  public Thread c()
  {
	lock (this.c_Conflict)
	{
	  Monitor.PulseAll(this.c_Conflict);
	  return this.e_Conflict;
	}
  }

  public void run()
  {
	object @object = null;
	while (true)
	{
	  try
	  {
		if (!this.a_Conflict)
		{
		  while (true)
		  {
			if (SYNTHETIC_LOCAL_VARIABLE_3 != null)
			{
			  SYNTHETIC_LOCAL_VARIABLE_3.disconnect();
			}
			try
			{
			  if (((DownloadJob)SYNTHETIC_LOCAL_VARIABLE_2).h >= 4 || SYNTHETIC_LOCAL_VARIABLE_2.b())
			  {
				ArrayList arrayList;
				if (((DownloadJob)SYNTHETIC_LOCAL_VARIABLE_2).a_Conflict == int.MinValue)
				{
				  this.d_Conflict = true;
				}
				lock (this.c_Conflict)
				{
				  this.c_Conflict.Remove(SYNTHETIC_LOCAL_VARIABLE_2);
				  try
				  {
					Thread.Sleep(10L);
				  }
				  catch (Exception)
				  {
				  }
				}
			  }
			}
			catch (Exception)
			{
			  try
			  {
				Thread.Sleep(10L);
			  }
			  catch (Exception)
			  {
			  }
			}
		  }
		  break;
		}
	  }
	  catch (Exception)
	  {

	  }
	  catch (Exception null)
	  {
		lock (this.c_Conflict)
		{
		  this.e_Conflict = null;
		}
	  }
	  finally
	  {
		null = null;
	  }
	  continue;
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\bh.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */