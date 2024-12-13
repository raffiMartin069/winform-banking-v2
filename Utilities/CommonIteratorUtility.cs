using Martinez_Bank.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Data.Linq;

namespace Martinez_Bank.Utilities
{
	/**
	 * <summary>
	 *	This class allows for the iteration of a collection of objects and returns a list of strings.
	 * </summary>
	 * **/
	public class CommonIteratorUtility
	{
		/**
		 * <summary>
		 *	This method iterates over a collection of objects and returns a list of strings.
		 * </summary>
		 * <param name="iterable">The collection of objects to iterate over.</param>
		 * <param name="prop">The property of the object to return as a string.</param>
		 * <returns>A list of strings.</returns>
		 * **/
		public List<string> Iterator<T>(IEnumerable<T> iterable, Func<T, string> prop)
		{
			var list = new List<string>();

			foreach (var i in iterable)
			{
				list.Add(prop(i));
			}

			return list;

		}
	}
}
