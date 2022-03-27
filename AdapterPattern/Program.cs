﻿using AdapterPattern.Interfaces;
using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ILumiaXMLTarget lumiaXMLTarget = new LumiaXMLAdapter();
            var xmlLumiaMobile = lumiaXMLTarget.GetLumiaMobilesXMLSpecifications();
            Console.WriteLine(xmlLumiaMobile.InnerText);
        }
    }
}
