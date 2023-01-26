using System;
using System.Linq;

namespace com.google.gson.@internal
{
	using fi;
	using fj;
	using fk;

	public sealed class $Gson$Types
	{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  public static readonly Type[] a_Conflict = new Type[0];

	  internal static Type a<T1>(Type<T1> paramType, Type paramClass1, Type paramClass2)
	  {
		Type clazz = paramClass1;
//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
//ORIGINAL LINE: java.lang.reflect.Type<?> type = paramType;
		Type<object> type = paramType;
		paramType = clazz;
		while (true)
		{
		  if (paramClass2 == paramType)
		  {
			continue;
		  }
		  if (paramClass2.IsInterface)
		  {
			Type[] arrayOfClass = paramType.getInterfaces();
			sbyte b = 0;
			int i = arrayOfClass.Length;
			while (b < i)
			{
			  if (arrayOfClass[b] == paramClass2)
			  {
				return paramType.getGenericInterfaces()[b];
			  }
			  if (paramClass2.IsAssignableFrom(arrayOfClass[b]))
			  {
				type = paramType.getGenericInterfaces()[b];
				paramType = arrayOfClass[b];
				goto label32Continue;
			  }
			  b++;
			}
		  }
		  type = paramClass2;
		  if (!paramType.isInterface())
		  {
			while (true)
			{
			  type = paramClass2;
			  if (paramType != typeof(object))
			  {
				type = paramType.BaseType;
				if (type == paramClass2)
				{
				  return paramType.getGenericSuperclass();
				}
				if (paramClass2.IsAssignableFrom((Type)type))
				{
				  Type type1 = paramType.getGenericSuperclass();
				  paramType = type;
				  type = type1;
				  goto label32Continue;
				}
				paramType = type;
				continue;
			  }
			  return type;
			}
			break;
		  }
		  continue;
			label32Continue:;
		}
		label32Break:;
	  }

	  public static GenericArrayType arrayOf(Type paramType)
	  {
		return (GenericArrayType)new fi(paramType);
	  }

	  internal static Type b(Type paramType, Type paramClass1, Type paramClass2)
	  {
		$Gson$Preconditions.checkArgument(paramClass2.IsAssignableFrom(paramClass1));
		return resolve(paramType, paramClass1, a(paramType, paramClass1, paramClass2));
	  }

	  public static Type canonicalize(Type paramType)
	  {
		fk fk;
		if (paramType is Type)
		{
		  fi fi;
		  paramType = paramType;
		  Type type1 = paramType;
		  if (paramType.isArray())
		  {
			fi = new fi(canonicalize(paramType.getComponentType()));
		  }
		  return (Type)fi;
		}
		if (paramType is ParameterizedType)
		{
		  paramType = paramType;
		  return (Type)new fj(paramType.getOwnerType(), paramType.getRawType(), paramType.getActualTypeArguments());
		}
		if (paramType is GenericArrayType)
		{
		  return (Type)new fi(((GenericArrayType)paramType).getGenericComponentType());
		}
		Type type = paramType;
		if (paramType is WildcardType)
		{
		  paramType = paramType;
		  fk = new fk(paramType.getUpperBounds(), paramType.getLowerBounds());
		}
		return (Type)fk;
	  }

	  public static bool equals(Type paramType1, Type paramType2)
	  {
		Type type = paramType1;
		paramType1 = paramType2;
		while (true)
		{
		  if (type == paramType1)
		  {
			return true;
		  }
		  if (type is Type)
		  {
			return type.Equals(paramType1);
		  }
		  if (type is ParameterizedType)
		  {
			bool @bool;
			if (!(paramType1 is ParameterizedType))
			{
			  return false;
			}
			paramType2 = type;
			type = paramType1;
			paramType1 = paramType2.getOwnerType();
			Type type1 = type.getOwnerType();
			if (paramType1 == type1 || (paramType1 != null && paramType1.Equals(type1)))
			{
			  @bool = true;
			}
			else
			{
			  @bool = false;
			}
			return (@bool && paramType2.getRawType().Equals(type.getRawType()) && (object[])paramType2.getActualTypeArguments().SequenceEqual((object[])type.getActualTypeArguments()));
		  }
		  if (type is GenericArrayType)
		  {
			if (!(paramType1 is GenericArrayType))
			{
			  return false;
			}
			paramType2 = type;
			paramType1 = paramType1;
			type = paramType2.getGenericComponentType();
			paramType1 = paramType1.getGenericComponentType();
			continue;
		  }
		  if (type is WildcardType)
		  {
			if (!(paramType1 is WildcardType))
			{
			  return false;
			}
			paramType2 = type;
			paramType1 = paramType1;
			return ((object[])paramType2.getUpperBounds().SequenceEqual((object[])paramType1.getUpperBounds()) && (object[])paramType2.getLowerBounds().SequenceEqual((object[])paramType1.getLowerBounds()));
		  }
		  if (type is TypeVariable)
		  {
			if (!(paramType1 is TypeVariable))
			{
			  return false;
			}
			paramType2 = type;
			paramType1 = paramType1;
			return (paramType2.getGenericDeclaration() == paramType1.getGenericDeclaration() && paramType2.getName().Equals(paramType1.getName()));
		  }
		  return false;
		}
	  }

	  public static Type getArrayComponentType<T1>(Type<T1> paramType)
	  {
		return (paramType is GenericArrayType) ? ((GenericArrayType)paramType).getGenericComponentType() : ((Type)paramType).GetElementType();
	  }

	  public static Type getCollectionElementType(Type paramType, Type paramClass)
	  {
		return ((ParameterizedType)b(paramType, paramClass, typeof(System.Collections.ICollection))).getActualTypeArguments()[0];
	  }

	  public static Type[] getMapKeyAndValueTypes(Type paramType, Type paramClass)
	  {
		if (paramType == typeof(Properties))
		{
		  null = new Type[2];
		  null[0] = typeof(string);
		  null[1] = typeof(string);
		  return null;
		}
		return ((ParameterizedType)b((Type)null, paramClass, typeof(System.Collections.IDictionary))).getActualTypeArguments();
	  }

	  public static Type getRawType<T1>(Type<T1> paramType)
	  {
		while (true)
		{
		  if (paramType is Type)
		  {
			return (Type)paramType;
		  }
		  if (paramType is ParameterizedType)
		  {
			paramType = ((ParameterizedType)paramType).getRawType();
			$Gson$Preconditions.checkArgument(paramType is Type);
			return (Type)paramType;
		  }
		  if (paramType is GenericArrayType)
		  {
			return Array.CreateInstance(getRawType(((GenericArrayType)paramType).getGenericComponentType()), 0).GetType();
		  }
		  if (paramType is TypeVariable)
		  {
			return typeof(object);
		  }
		  if (paramType is WildcardType)
		  {
			paramType = ((WildcardType)paramType).getUpperBounds()[0];
			continue;
		  }
		  if (paramType == null)
		  {
			string str1 = "null";
			throw new System.ArgumentException("Expected a Class, ParameterizedType, or GenericArrayType, but <" + paramType + "> is of type " + str1);
		  }
//JAVA TO C# CONVERTER WARNING: The .NET Type.FullName property will not always yield results identical to the Java Class.getName method:
		  string str = paramType.GetType().FullName;
		  throw new System.ArgumentException("Expected a Class, ParameterizedType, or GenericArrayType, but <" + paramType + "> is of type " + str);
		}
	  }

	  public static bool isArray(Type paramType)
	  {
		return (paramType is GenericArrayType || (paramType is Type && ((Type)paramType).IsArray));
	  }

	  public static ParameterizedType newParameterizedTypeWithOwner(Type paramType1, Type paramType2, params Type[] paramVarArgs)
	  {
		return (ParameterizedType)new fj(paramType1, paramType2, paramVarArgs);
	  }

	  public static Type resolve<T1>(Type paramType1, Type paramClass, Type<T1> paramType2)
	  {
		Type type;
		Type[] arrayOfType2;
		sbyte b = 0;
//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
//ORIGINAL LINE: java.lang.reflect.Type<?> type1;
		Type<object> type1;
		for (type1 = paramType2; type1 is TypeVariable; type1 = paramType2)
		{
		  type1 = type1;
		  paramType2 = type1.getGenericDeclaration();
		  if (paramType2 is Type)
		  {
			paramType2 = paramType2;
		  }
		  else
		  {
			paramType2 = null;
		  }
		  if (paramType2 == null)
		  {
			paramType2 = type1;
			continue;
		  }
		  Type type2 = a(paramType1, paramClass, (Type)paramType2);
		  if (type2 is ParameterizedType)
		  {
			TypeVariable[] arrayOfTypeVariable = paramType2.getTypeParameters();
			sbyte b1 = 0;
			while (true)
			{
			  if (b1 < arrayOfTypeVariable.Length)
			  {
				if (type1.Equals(arrayOfTypeVariable[b1]))
				{
				  type = ((ParameterizedType)type2).getActualTypeArguments()[b1];
				  if (type == type1)
				  {
					return type;
				  }
				  break;
				}
				b1++;
				continue;
			  }
			  throw new NoSuchElementException();
			}
		  }
		  else
		  {
			paramType2 = type1;
			continue;
		  }
		}
		if (type1 is Type && ((Type)type1).IsArray)
		{
		  paramType2 = type1;
		  type1 = paramType2.getComponentType();
		  paramType1 = resolve(paramType1, paramClass, type1);
		  if (type1 != paramType1)
		  {
			paramType2 = arrayOf(paramType1);
		  }
		  return paramType2;
		}
		if (type1 is GenericArrayType)
		{
		  paramType2 = type1;
		  type1 = paramType2.getGenericComponentType();
		  paramType1 = resolve(paramType1, paramClass, type1);
		  if (type1 != paramType1)
		  {
			paramType2 = arrayOf(paramType1);
		  }
		  return paramType2;
		}
		if (type1 is ParameterizedType)
		{
		  bool @bool;
		  ParameterizedType parameterizedType = (ParameterizedType)type1;
		  paramType2 = parameterizedType.getOwnerType();
		  Type type2 = resolve(paramType1, paramClass, paramType2);
		  if (type2 != paramType2)
		  {
			@bool = true;
		  }
		  else
		  {
			@bool = false;
		  }
		  arrayOfType2 = parameterizedType.getActualTypeArguments();
		  int i = arrayOfType2.Length;
		  while (b < i)
		  {
			Type type3 = resolve(paramType1, paramClass, arrayOfType2[b]);
			Type[] arrayOfType = arrayOfType2;
			bool bool1 = @bool;
			if (type3 != arrayOfType2[b])
			{
			  arrayOfType = arrayOfType2;
			  bool1 = @bool;
			  if (!@bool)
			  {
				arrayOfType = (Type[])(Type[])arrayOfType2.Clone();
				bool1 = true;
			  }
			  arrayOfType[b] = type3;
			}
			b++;
			arrayOfType2 = arrayOfType;
			@bool = bool1;
		  }
		  paramType2 = parameterizedType;
		  if (@bool)
		  {
			paramType2 = newParameterizedTypeWithOwner(type2, parameterizedType.getRawType(), arrayOfType2);
		  }
		  return paramType2;
		}
		Type[] arrayOfType1 = arrayOfType2;
		if (arrayOfType2 is WildcardType)
		{
		  WildcardType wildcardType = (WildcardType)arrayOfType2;
		  Type[] arrayOfType4 = wildcardType.getLowerBounds();
		  Type[] arrayOfType3 = wildcardType.getUpperBounds();
		  if (arrayOfType4.Length == 1)
		  {
			paramType1 = resolve(paramType1, paramClass, arrayOfType4[0]);
			WildcardType wildcardType1 = wildcardType;
			if (paramType1 != arrayOfType4[0])
			{
			  wildcardType1 = supertypeOf(paramType1);
			}
			return wildcardType1;
		  }
		  type = wildcardType;
		  if (arrayOfType3.Length == 1)
		  {
			paramType1 = resolve(paramType1, paramClass, arrayOfType3[0]);
			type = wildcardType;
			if (paramType1 != arrayOfType3[0])
			{
			  type = subtypeOf(paramType1);
			}
		  }
		}
		return type;
	  }

	  public static WildcardType subtypeOf(Type paramType)
	  {
		Type[] arrayOfType = a_Conflict;
		return (WildcardType)new fk(new Type[] {paramType}, arrayOfType);
	  }

	  public static WildcardType supertypeOf(Type paramType)
	  {
		return (WildcardType)new fk(new Type[] {typeof(object)}, new Type[] {paramType});
	  }

	  public static string typeToString(Type paramType)
	  {
//JAVA TO C# CONVERTER WARNING: The .NET Type.FullName property will not always yield results identical to the Java Class.getName method:
		return (paramType is Type) ? ((Type)paramType).FullName : paramType.ToString();
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\com\google\gson\internal\$Gson$Types.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}