﻿using System.Collections.Generic;

namespace Skyra.Framework.Structures.Base
{
	public class Store<T> : Dictionary<string, T> where T : Piece
	{
		public Store<T> Insert(T instance)
		{
			Add(instance.Name, instance);
			return this;
		}
	}
}
