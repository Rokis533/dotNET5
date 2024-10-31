﻿namespace WEBAPI
{
	public interface ISingletonService
	{
		int Increment();
	}

	public class SingletonService : ISingletonService
	{

		public SingletonService()
		{

		}

		private int counter;

		public int Increment()
		{
			return counter++;
		}
	}
}