using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Nuterra.Extensions
{
	public static class TankBlockExtensions
	{
		public static void Nuterra_SetBlockCategory(this TankBlock tankBlock, BlockCategories category)
		{
			typeof(TankBlock).GetField("m_BlockCategory", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(tankBlock, category);
		}
	}
}
