﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OS.Social.WX;
using OS.Social.WX.Offcial;

namespace OS.Social.Wx.Tests
{
    [TestClass]
    public class WxBaseOffcialApiTests
    {
        protected static WxAppCoinfig m_Config = new WxAppCoinfig()
        {
            AppId = "wxaa9e6cb3f03afa97",
            AppSecret = "0fc0c6f735a90fda1df5fc840e010144"
        };


        private static WxOffcialBaseApi m_Api = new WxOffcialBaseApi(m_Config);
        public WxBaseOffcialApiTests()
        {

        }

        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，该上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }


  

        [TestMethod]
        public void GetWxIpListTest()
        {
            var iplist = m_Api.GetWxIpList();
            Assert.IsTrue(iplist.IsSuccess && iplist.ip_list.Count > 0);
        }




        //public void SendTemplateTest()
        //{
        //    //	4E7QKo8GhQ0pNHDAfE3Z-w7vEWULDT3ZflBJUMYpd7s     	{{first.DATA}} 交易时间：{{trade_time.DATA}} 金额：{{money.DATA}} {{remark.DATA}}


        //}




    }
}
