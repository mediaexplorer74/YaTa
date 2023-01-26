﻿//---------------------------------------------------------------------------------------------------------
//	Copyright © 2007 - 2022 Tangible Software Solutions, Inc.
//	This class can be used by anyone provided that the copyright notice remains intact.
//
//	This class is used to replace calls to some Java Collection methods.
//---------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

internal static class CollectionHelper
{
	public static bool ContainsAll<T>(this ICollection<T> c1, ICollection<T> c2)
	{
		if (c2 is null)
			throw new NullReferenceException();

		foreach (T item in c2)
		{
			if (!c1.Contains(item))
				return false;
		}
		return true;
	}

	public static bool RemoveAll<T>(this ICollection<T> c1, ICollection<T> c2)
	{
		if (c2 is null)
			throw new NullReferenceException();

		bool changed = false;
		foreach (T item in c2)
		{
			if (c1.Contains(item))
			{
				c1.Remove(item);
				changed = true;
			}
		}
		return changed;
	}

	public static bool RetainAll<T>(this ICollection<T> c1, ICollection<T> c2)
	{
		if (c2 is null)
			throw new NullReferenceException();

		bool changed = false;
		T[] arrayCopy = new T[c1.Count];
		c1.CopyTo(arrayCopy, 0);
		foreach (T item in arrayCopy)
		{
			if (!c2.Contains(item))
			{
				c1.Remove(item);
				changed = true;
			}
		}
		return changed;
	}
}