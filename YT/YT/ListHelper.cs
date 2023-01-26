﻿//---------------------------------------------------------------------------------------------------------
//	Copyright © 2007 - 2022 Tangible Software Solutions, Inc.
//	This class can be used by anyone provided that the copyright notice remains intact.
//
//	This class is used to replace calls to some Java List methods.
//---------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

internal static class ListHelper
{
	public static T RemoveAndReturn<T>(this IList<T> list, int index)
	{
		if (index > list.Count - 1)
			throw new System.IndexOutOfRangeException();

		T foundItem = list[index];
		list.RemoveAt(index);
		return foundItem;
	}
}