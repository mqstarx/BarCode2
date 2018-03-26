namespace DataBase
{
    public enum ProtocolOfExchange
    {
        CheckConnection, CheckConnectionOK,AskDictionary,AskDictionaryOk,AskDbCollection,AskDbCollectionOk,AddBase,AddBaseOk,AddBaseFail,DelBase,DelBaseOk,
        DelBaseFail,AddQrItemInBase, AddQrItemInBaseOk, AddQrItemInBaseFail, AddQrItemSInBase, AddQrItemSInBaseOk, AddQrItemSInBaseFail,DelDbItem, DelDbItemOK,
        DelDbItemFail, DelDbItems, DelDbItemsOK,
        DelDbItemsFail
    }
}