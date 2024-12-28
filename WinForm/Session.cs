using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martinez_Bank.WinForm.Sessions
{
	public static class Session
	{
		public static Dictionary<string, object> Claims = new Dictionary<string, object>();

		public static void Set(string key, object value)
		{
			if (Claims.ContainsKey(key))
			{
				Claims[key] = value;
			}
			else
			{
				Claims.Add(key, value);
			}
		}

		public static object Get(string key)
		{
			Claims.TryGetValue(key, out var value);
			return value;
		}

		public static bool ContainsKey(string key)
		{
			return Claims.ContainsKey(key);
		}

		public static void Remove(string key)
		{
			Claims.Remove(key);
		}

		public static void Clear()
		{
			Claims.Clear();
		}
	}
}
