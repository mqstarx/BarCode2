﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataBase;
using BarCode2;
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
            DictionaryItem di6 = new DictionaryItem(type, datalen6, datadescr, true,false,false, null, 0);
            DictionaryItem di = new DictionaryItem(type, datalen, datadescr, true,false,false, null, 0);
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
        [TestMethod]
        public void ParseQrCodeTest()
        {
            //arrange
            QrProcessor qrproc = new QrProcessor();
            Dictionary di = new Dictionary();
            di.ReadFromIni();
            string pac = "sdfsdFFX007N001088FXX2342333423";
            string pac1 = "sdfsdFFX039N001088FFY007N000001FYYFFY007N000002FYYFXX2342333423";
            //act

            //  string tested = qr.GenerateQrCode(false);

            //assert
           // Assert.AreEqual(null, qrproc.ParseQrPacket(pac.ToCharArray(), di));
            Assert.AreEqual("FFX039N001088FFY007N000001FYYFFY007N000002FYYFXX", qrproc.ParseQrPacket(pac1.ToCharArray(), di).GenerateQrCode(false));
        }
        [TestMethod]
        public void FindPacketDataTest()
        {
            //arrange
            QrProcessor qrproc = new QrProcessor();
            string pac = "sdfsdFFX030N001FFY004P002FYYFFY004P003FYYFXX2342333423";
           

            //act

            string expected = "N001FFY004P002FYYFFY004P003FYY";
            string expected1 = "P002";
            //assert
            Assert.AreEqual(expected, qrproc.FindPacketData(pac,"FFX","FXX",3));
            Assert.AreEqual(expected1, qrproc.FindPacketData(expected, "FFY", "FYY", 3));
        }
       
        [TestMethod]
        public void IsQrItemInBaseTest()
        {
            //arrange
            DataBasesCollection dbCollection = new DataBasesCollection();
           // dbCollection.AddDataBase(new DataBase.DataBase("P", "typeDescr", "Test1"));
            
           // dbCollection.DataBaseCollection[0].DataBaseNode.DataBaseCollection[0].DataBaseItems.Add(new DataBaseItem(new QrItem("D", "1234"),"FFSSDASDASSSSDAS"));
          //  dbCollection.DataBaseCollection[0].DataBaseNode.DataBaseCollection[0].DataBaseItems.Add(new DataBaseItem(new QrItem("D", "12345"), "FFSSDASDASSSSDAS"));

            Assert.AreEqual(true,dbCollection.IsQrItemInBase(new QrItem("D", "1234")));
            Assert.AreNotEqual(true, dbCollection.IsQrItemInBase(new QrItem("P", "1234")));

        }
       
    }
}
