﻿namespace WEBAPI
{
    public interface IScopedService
    {
        int Increment();
    }

    public class ScopedService : IScopedService
    {
        public ScopedService()
        {

        }


        private int counter = 1;

        public int Increment()
        {
            return counter++;
        }
    }
}
