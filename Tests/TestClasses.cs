using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataBase;

namespace Tests
{
    [TestClass]
    public class TestClasses
    {
        [TestMethod]
        public void TestDictionaryItemConstructorCreate()
        {
            //arrange
            string type = "DF";
            int datalen6 = 6;
            int datalen = 3;
            string datadescr = "testТест";

            bool expected_isDate6 = true;
            bool expected_isDate = false;


            //act
            DictionaryItem di6 = new DictionaryItem(type, datalen6, datadescr, true, null, 0);
            DictionaryItem di = new DictionaryItem(type, datalen, datadescr, true, null, 0);
            //assert

            Assert.AreEqual(expected_isDate6, di6.Is_date);
            Assert.AreEqual(expected_isDate, di.Is_date);
            Assert.AreEqual(2, di.TypeLen);
            Assert.AreEqual(null, di.KeyValues);

        }
        [TestMethod]
        public void DictionaryReadIniTest()
        {
            //arrange
            int test_count = 11;
            //act
            Dictionary di = new Dictionary();
            di.ReadFromIni();
            //assert
            Assert.AreEqual(test_count>0, di.DictionaryDataBase.Count>0);
        }
        [TestMethod]
        public void GenerateQrCodeTest()
        {
            //arrange
            QrCodeData qr = new QrCodeData();
            qr.AddQritem(new QrItem("P", "01"));
            qr.AddQritem(new QrItem("N", "02"));
            QrCodeData qr1 = new QrCodeData();
            qr1.AddQritem(new QrItem("P", "01"));
            qr1.AddQritem(new QrItem("N", "02"));
            qr.AddQrInPacket(qr1);
            string expected = "FFX021P01N02FFY006P01N02FYYFXX";
            //act

            string tested = qr.GenerateQrCode(false);

            //assert
            Assert.AreEqual(expected, tested);
        }
       
        [TestMethod]
        public void GenerateQrCodeTestNullEmptyString()
        {
            //arrange
            QrCodeData qr = new QrCodeData();
            qr.AddQritem(new QrItem("P", "01"));
            qr.AddQritem(new QrItem("N", "02"));
            QrCodeData qr1 = new QrCodeData();
            qr1.AddQritem(new QrItem("P", "01"));
            qr1.AddQritem(new QrItem(null, ""));
            qr.AddQrInPacket(qr1);
            string expected = "FFX018P01N02FFY003P01FYYFXX";
            //act

            string tested = qr.GenerateQrCode(false);

            //assert
            Assert.AreEqual(expected, tested);
        }
    }
}
