using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TravelAgency.Common;

namespace TravelAgency.CSUI.Test
{
    [TestClass]
    public class TestDateTimeFormator
    {
        [TestMethod]
        public void TestGetNextWorkDay()
        {
            DateTime dateTime = DateTime.Parse("2017/9/30");
            DateTime nextWorkDate = DateTimeFormator.GetNextWorkDate(dateTime);
            string[] infos = "a".Split('|');
        }


    }
}
