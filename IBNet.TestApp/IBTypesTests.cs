#region ZGT
// (c) Copyright 2020 ZTG LLC. All Rights Reserved.
// NOTICE: This file contains source code, ideas, techniques, and information (the Information) which are
// Proprietary and Confidential Information of ZTG LLC. This Information may not be used by or disclosed to any
// third party except under written license, and shall be subject to the limitations prescribed under license.
#endregion

using System;
using System.Collections.Generic;
using System.Reflection;
using IBNet.Enums;
using NUnit.Framework;
using DescriptionAttribute = System.ComponentModel.DescriptionAttribute;

namespace IBNet.TestApp
{
    [TestFixture]
    public class IBTypesTests
    {
        [Test]
        public void ActionSideTest()
        {
            ActionSide side = ActionSide.Buy;

            Assert.AreEqual("BUY", side.Value);
            Assert.AreEqual("Buy", side.Name);
        }


        [Test]
        public void EnumToEnumeration()
        {
            var e = typeof(OrderStatus);

            foreach (var fi in e.GetFields())
            {
                if (fi.FieldType != e) continue;

                DescriptionAttribute[] attributes = (DescriptionAttribute[]) fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
                Enum                   val        = (Enum) fi.GetValue(fi.Name);
                string                 strVal     = attributes.Length > 0 ? attributes[0].Description : val.ToString();
                int                    intEnumVal = (int) Convert.ChangeType(val, Enum.GetUnderlyingType(val.GetType()));
                //DumpLine0(e.Name, val.ToString(), intEnumVal);
                DumpLine1(e.Name, val.ToString(), attributes[0].Description, intEnumVal);
                //DumpLine2(e.Name, val.ToString(), attributes[0].Description, intEnumVal);
            }
        }

        public void DumpLine0(string type, string varName, int intval)
        {
            string template = "public static ttt vvv = new ttt(intval, nameof(vvv));";
            var line = template.Replace("ttt", type)
                               .Replace("vvv", varName)
                               .Replace("intval", intval.ToString());
            Console.WriteLine(line);
        }

        public void DumpLine1(string type, string varName, string desc, int intval)
        {
            string template = "public static ttt vvv = new ttt(\"val\", nameof(vvv));";
            var line = template.Replace("ttt", type)
                               .Replace("vvv", varName)
                               .Replace("val", desc);
            Console.WriteLine(line);
        }

        public void DumpLine2(string type, string varName, string desc, int intval)
        {
            string template = "public static type varName = new type(intval, nameof(varName), \"desc\");";
            var line = template.Replace("type", type)
                               .Replace("intval", intval.ToString())
                               .Replace("varName", varName)
                               .Replace("desc", desc);
            Console.WriteLine(line);
        }
    }
}