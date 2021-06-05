#region ZGT
// (c) Copyright 2021 ZTG LLC. All Rights Reserved.
// NOTICE: This file contains source code, ideas, techniques, and information (the Information) which are
// Proprietary and Confidential Information of ZTG LLC. This Information may not be used by or disclosed to any
// third party except under written license, and shall be subject to the limitations prescribed under license.
#endregion

using System;
using System.IO;
using IbFlexReader.Contracts;
using NUnit.Framework;

namespace IBNet.TestApp
{
    [TestFixture]
    public class FlexReportTest
    {
        [Test]
        public void FlexReaderTest()
        {
            // string reportFilName = @"c:\Loraq\Reports\IbFlex\Export\F488917_multi5_20200508_20210507_AF_535072_767e61db75dcae4546dabb286ce8d2c2.xml";
            string reportFilName = @"c:\Loraq\Reports\IbFlex\2021\19\FA-Last365Days-20210510.2.xml";

            string            content = File.ReadAllText(reportFilName);
            FlexQueryResponse result  = new IbFlexReader.Reader().GetByString(content);
            Console.Write("done");
        }
    }
}
