using System;

namespace System.Maui
{
	public class ScrolledEventArgs : EventArgs
	{
		public ScrolledEventArgs(double x, double y)
		{
			ScrollX = x;
			ScrollY = y;
		}

		public double ScrollX { get; private set; }

		public double ScrollY { get; private set; }
	}
}