using System;
using System.Collections.Generic;

namespace com.google.gson
{
	using be;
	using  = com.google.gson.@internal.;
	using eh;
	using eq;

	public sealed class FieldAttributes
	{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private static readonly be<eq<Type, string>, ICollection<Annotation>> a_Conflict = (be<eq<Type, string>, ICollection<Annotation>>)new eh(d());

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private readonly Type b_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private readonly System.Reflection.FieldInfo c_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private readonly Type d_Conflict;

	  private readonly bool e;

	  private readonly int f;

	  private readonly string g;

	  private readonly Type h;

	  private Type i;

	  private ICollection<Annotation> j;

	  public FieldAttributes(Type paramClass, System.Reflection.FieldInfo paramField, Type paramType)
	  {
		Type type;
		this.b_Conflict = (Class).Gson.Preconditions.checkNotNull(paramClass);
		this.g = paramField.getName();
		this.d_Conflict = paramField.getType();
		this.e = paramField.isSynthetic();
		this.f = paramField.getModifiers();
		this.c_Conflict = paramField;
		paramClass = .Gson.Types.getRawType(paramType);
		if (!paramField.getDeclaringClass().isAssignableFrom(paramClass))
		{
		  type = paramField.getGenericType();
		}
		else
		{
		  type = .Gson.Types.resolve(paramType, (Type)type, paramField.getGenericType());
		}
		this.h = type;
	  }

	  private static int d()
	  {
		int i = 2000;
		try
		{
		  int j = int.Parse(System.getProperty("com.google.gson.annotation_cache_size_hint", 2000.ToString()));
		  i = j;
		}
		catch (System.FormatException)
		{
		}
		return i;
	  }

	  public object a(object paramObject)
	  {
		return this.c_Conflict.get(paramObject);
	  }

	  public void a(object paramObject1, object paramObject2)
	  {
		this.c_Conflict.set(paramObject1, paramObject2);
	  }

	  public bool a()
	  {
		return this.e;
	  }

	  [Obsolete]
	  public System.Reflection.FieldInfo b()
	  {
		return this.c_Conflict;
	  }

	  public Type c()
	  {
		return this.h;
	  }

	  public T getAnnotation<T>(Type paramClass) where T : java.lang.annotation.Annotation
	  {
		// Byte code:
		//   0: aload_0
		//   1: invokevirtual getAnnotations : ()Ljava/util/Collection;
		//   4: invokeinterface iterator : ()Ljava/util/Iterator;
		//   9: astore_2
		//   10: aload_2
		//   11: invokeinterface hasNext : ()Z
		//   16: ifeq -> 43
		//   19: aload_2
		//   20: invokeinterface next : ()Ljava/lang/Object;
		//   25: checkcast java/lang/annotation/Annotation
		//   28: astore_3
		//   29: aload_3
		//   30: invokeinterface annotationType : ()Ljava/lang/Class;
		//   35: aload_1
		//   36: if_acmpne -> 10
		//   39: aload_3
		//   40: astore_1
		//   41: aload_1
		//   42: areturn
		//   43: aconst_null
		//   44: astore_1
		//   45: goto -> 41
	  }

	  public ICollection<Annotation> Annotations
	  {
		  get
		  {
			if (this.j == null)
			{
			  eq eq = new eq(this.b_Conflict, this.g);
			  this.j = (ICollection<Annotation>)a.a(eq);
			  if (this.j == null)
			  {
				this.j = Collections.unmodifiableCollection(Arrays.asList(this.c_Conflict.GetCustomAttributes(true)));
				a.a(eq, this.j);
			  }
			}
			return this.j;
		  }
	  }

	  public Type DeclaredClass
	  {
		  get
		  {
			return this.d_Conflict;
		  }
	  }

	  public Type DeclaredType
	  {
		  get
		  {
			if (this.i == null)
			{
			  this.i = this.c_Conflict.getGenericType();
			}
			return this.i;
		  }
	  }

	  public Type DeclaringClass
	  {
		  get
		  {
			return this.b_Conflict;
		  }
	  }

	  public string Name
	  {
		  get
		  {
			return this.g;
		  }
	  }

	  public bool hasModifier(int paramInt)
	  {
		return ((this.f & paramInt) != 0);
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\com\google\gson\FieldAttributes.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}