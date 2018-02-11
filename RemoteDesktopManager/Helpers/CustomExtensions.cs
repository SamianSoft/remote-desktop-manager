using System;
using System.ComponentModel;
using System.Reflection;

namespace RemoteDesktopManager.Helpers
{
    public static class CustomExtensions
    {
        public static long ToLong(this ScreenSize size)
        {
            return (long)size;
        }
        public static long ToLong(this DisplayColor color)
        {
            return (long)color;
        }
    }
}