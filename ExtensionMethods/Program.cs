﻿namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var str = "This is a test";

            str.Debug("str is:");

            var i = 12;
            i.Debug(str);

            i.Cubed().Debug(str);

            i.Func().Debug("F({i}) = ");
        }
    }
}
