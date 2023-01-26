using System;
using System.Collections.Generic;
using System.Text;

namespace com.google.gson.reflect
{
	using  = com.google.gson.@internal.;

	public class TypeToken<T>
	{
//JAVA TO C# CONVERTER TODO TASK: There is no C# equivalent to the Java 'super' constraint:
//ORIGINAL LINE: final Class<? super T> a;
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
	  internal readonly Type a_Conflict = typeof(?);

	  internal readonly Type b;

	  internal readonly int c;

	  protected internal TypeToken()
	  {
		Type type = this.GetType().getGenericSuperclass();
		if (type is Type)
		{
		  throw new Exception("Missing type parameter.");
		}
		this.b = .Gson.Types.canonicalize(((ParameterizedType)type).getActualTypeArguments()[0]);
		this.a_Conflict = .Gson.Types.getRawType(this.b);
		this.c = this.b.GetHashCode();
	  }

	  internal TypeToken(Type paramType)
	  {
		this.b = .Gson.Types.canonicalize((Type).Gson.Preconditions.checkNotNull(paramType));
		this.a_Conflict = .Gson.Types.getRawType(this.b);
		this.c = this.b.GetHashCode();
	  }

	  private static AssertionError a(Type paramType, params Type[] paramVarArgs)
	  {
		StringBuilder stringBuilder = new StringBuilder("Unexpected type. Expected one of: ");
		int i = paramVarArgs.Length;
		for (sbyte b = 0; b < i; b++)
		{
//JAVA TO C# CONVERTER WARNING: The .NET Type.FullName property will not always yield results identical to the Java Class.getName method:
		  stringBuilder.Append(paramVarArgs[b].FullName).Append(", ");
		}
//JAVA TO C# CONVERTER WARNING: The .NET Type.FullName property will not always yield results identical to the Java Class.getName method:
		stringBuilder.Append("but got: ").Append(paramType.GetType().FullName).Append(", for type token: ").Append(paramType.ToString()).Append('.');
		return new AssertionError(stringBuilder.ToString());
	  }

	  private static bool a<T1>(Type<T1> paramType, GenericArrayType paramGenericArrayType)
	  {
//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
//ORIGINAL LINE: java.lang.reflect.Type<?> type;
		Type<object> type;
		Type type1 = paramGenericArrayType.getGenericComponentType();
		if (type1 is ParameterizedType)
		{
		  if (paramType is GenericArrayType)
		  {
			type = ((GenericArrayType)paramType).getGenericComponentType();
		  }
		  else
		  {
			type = paramType;
			if (paramType is Type)
			{
			  paramType = paramType;
			  while (true)
			  {
				type = paramType;
				if (paramType.isArray())
				{
				  paramType = paramType.getComponentType();
				  continue;
				}
				return a(type, (ParameterizedType)type1, new Dictionary<string, Type>());
			  }
			}
		  }
		}
		else
		{
		  return true;
		}
		return a(type, (ParameterizedType)type1, new Dictionary<string, Type>());
	  }

	  private static bool a(Type paramType, ParameterizedType paramParameterizedType, IDictionary<string, Type> paramMap)
	  {
		// Byte code:
		//   0: iconst_0
		//   1: istore_3
		//   2: aload_0
		//   3: ifnonnull -> 8
		//   6: iload_3
		//   7: ireturn
		//   8: aload_1
		//   9: aload_0
		//   10: invokevirtual equals : (Ljava/lang/Object;)Z
		//   13: ifeq -> 21
		//   16: iconst_1
		//   17: istore_3
		//   18: goto -> 6
		//   21: aload_0
		//   22: invokestatic getRawType : (Ljava/lang/reflect/Type;)Ljava/lang/Class;
		//   25: astore #4
		//   27: aload_0
		//   28: instanceof java/lang/reflect/ParameterizedType
		//   31: ifeq -> 347
		//   34: aload_0
		//   35: checkcast java/lang/reflect/ParameterizedType
		//   38: astore_0
		//   39: aload_0
		//   40: ifnull -> 279
		//   43: aload_0
		//   44: invokeinterface getActualTypeArguments : ()[Ljava/lang/reflect/Type;
		//   49: astore #5
		//   51: aload #4
		//   53: invokevirtual getTypeParameters : ()[Ljava/lang/reflect/TypeVariable;
		//   56: astore #6
		//   58: iconst_0
		//   59: istore #7
		//   61: iload #7
		//   63: aload #5
		//   65: arraylength
		//   66: if_icmpge -> 137
		//   69: aload #5
		//   71: iload #7
		//   73: aaload
		//   74: astore #8
		//   76: aload #6
		//   78: iload #7
		//   80: aaload
		//   81: astore #9
		//   83: aload #8
		//   85: instanceof java/lang/reflect/TypeVariable
		//   88: ifeq -> 115
		//   91: aload_2
		//   92: aload #8
		//   94: checkcast java/lang/reflect/TypeVariable
		//   97: invokeinterface getName : ()Ljava/lang/String;
		//   102: invokeinterface get : (Ljava/lang/Object;)Ljava/lang/Object;
		//   107: checkcast java/lang/reflect/Type
		//   110: astore #8
		//   112: goto -> 83
		//   115: aload_2
		//   116: aload #9
		//   118: invokeinterface getName : ()Ljava/lang/String;
		//   123: aload #8
		//   125: invokeinterface put : (Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;
		//   130: pop
		//   131: iinc #7, 1
		//   134: goto -> 61
		//   137: aload_0
		//   138: invokeinterface getRawType : ()Ljava/lang/reflect/Type;
		//   143: aload_1
		//   144: invokeinterface getRawType : ()Ljava/lang/reflect/Type;
		//   149: invokevirtual equals : (Ljava/lang/Object;)Z
		//   152: ifeq -> 273
		//   155: aload_0
		//   156: invokeinterface getActualTypeArguments : ()[Ljava/lang/reflect/Type;
		//   161: astore #9
		//   163: aload_1
		//   164: invokeinterface getActualTypeArguments : ()[Ljava/lang/reflect/Type;
		//   169: astore #6
		//   171: iconst_0
		//   172: istore #7
		//   174: iload #7
		//   176: aload #9
		//   178: arraylength
		//   179: if_icmpge -> 267
		//   182: aload #9
		//   184: iload #7
		//   186: aaload
		//   187: astore_0
		//   188: aload #6
		//   190: iload #7
		//   192: aaload
		//   193: astore #8
		//   195: aload #8
		//   197: aload_0
		//   198: invokevirtual equals : (Ljava/lang/Object;)Z
		//   201: ifne -> 234
		//   204: aload_0
		//   205: instanceof java/lang/reflect/TypeVariable
		//   208: ifeq -> 255
		//   211: aload #8
		//   213: aload_2
		//   214: aload_0
		//   215: checkcast java/lang/reflect/TypeVariable
		//   218: invokeinterface getName : ()Ljava/lang/String;
		//   223: invokeinterface get : (Ljava/lang/Object;)Ljava/lang/Object;
		//   228: invokevirtual equals : (Ljava/lang/Object;)Z
		//   231: ifeq -> 255
		//   234: iconst_1
		//   235: istore #10
		//   237: iload #10
		//   239: ifne -> 261
		//   242: iconst_0
		//   243: istore #7
		//   245: iload #7
		//   247: ifeq -> 279
		//   250: iconst_1
		//   251: istore_3
		//   252: goto -> 6
		//   255: iconst_0
		//   256: istore #10
		//   258: goto -> 237
		//   261: iinc #7, 1
		//   264: goto -> 174
		//   267: iconst_1
		//   268: istore #7
		//   270: goto -> 245
		//   273: iconst_0
		//   274: istore #7
		//   276: goto -> 245
		//   279: aload #4
		//   281: invokevirtual getGenericInterfaces : ()[Ljava/lang/reflect/Type;
		//   284: astore_0
		//   285: aload_0
		//   286: arraylength
		//   287: istore #10
		//   289: iconst_0
		//   290: istore #7
		//   292: iload #7
		//   294: iload #10
		//   296: if_icmpge -> 329
		//   299: aload_0
		//   300: iload #7
		//   302: aaload
		//   303: aload_1
		//   304: new java/util/HashMap
		//   307: dup
		//   308: aload_2
		//   309: invokespecial <init> : (Ljava/util/Map;)V
		//   312: invokestatic a : (Ljava/lang/reflect/Type;Ljava/lang/reflect/ParameterizedType;Ljava/util/Map;)Z
		//   315: ifeq -> 323
		//   318: iconst_1
		//   319: istore_3
		//   320: goto -> 6
		//   323: iinc #7, 1
		//   326: goto -> 292
		//   329: aload #4
		//   331: invokevirtual getGenericSuperclass : ()Ljava/lang/reflect/Type;
		//   334: astore_0
		//   335: new java/util/HashMap
		//   338: dup
		//   339: aload_2
		//   340: invokespecial <init> : (Ljava/util/Map;)V
		//   343: astore_2
		//   344: goto -> 2
		//   347: aconst_null
		//   348: astore_0
		//   349: goto -> 39
	  }

	  public static TypeToken<T> get<T>(Type paramClass)
	  {
		return new TypeToken<T>(paramClass);
	  }

//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
//ORIGINAL LINE: public static TypeToken<?> get(java.lang.reflect.Type paramType)
	  public static TypeToken<object> get(Type paramType)
	  {
		return new TypeToken(paramType);
	  }

	  public sealed override bool Equals(object paramObject)
	  {
		return (paramObject is TypeToken && .Gson.Types.equals(this.b, ((TypeToken)paramObject).b));
	  }

//JAVA TO C# CONVERTER TODO TASK: There is no C# equivalent to the Java 'super' constraint:
//ORIGINAL LINE: public final Class<? super T> getRawType()
//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
	  public Type<object> RawType
	  {
		  get
		  {
			return this.a_Conflict;
		  }
	  }

	  public Type Type
	  {
		  get
		  {
			return this.b;
		  }
	  }

	  public sealed override int GetHashCode()
	  {
		return this.c;
	  }

	  [Obsolete]
	  public virtual bool isAssignableFrom<T1>(TypeToken<T1> paramTypeToken)
	  {
		return isAssignableFrom(paramTypeToken.Type);
	  }

	  [Obsolete]
	  public virtual bool isAssignableFrom(Type paramClass)
	  {
		return isAssignableFrom(paramClass);
	  }

	  [Obsolete]
	  public virtual bool isAssignableFrom(Type paramType)
	  {
		if (paramType == null)
		{
		  return false;
		}
		if (this.b.Equals(paramType))
		{
		  return true;
		}
		if (this.b is Type)
		{
		  return this.a_Conflict.IsAssignableFrom(.Gson.Types.getRawType(paramType));
		}
		if (this.b is ParameterizedType)
		{
		  return a(paramType, (ParameterizedType)this.b, new Dictionary<string, Type>());
		}
		if (this.b is GenericArrayType)
		{
		  return (this.a_Conflict.IsAssignableFrom(.Gson.Types.getRawType(paramType)) && a(paramType, (GenericArrayType)this.b));
		}
		throw a(this.b, new Type[] {typeof(Type), typeof(ParameterizedType), typeof(GenericArrayType)});
	  }

	  public sealed override string ToString()
	  {
		return.Gson.Types.typeToString(this.b);
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\com\google\gson\reflect\TypeToken.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}