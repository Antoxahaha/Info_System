using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiceCentralStock
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService1" в коде и файле конфигурации.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        List<CommingUp> Select_Comming_Phones();
        [OperationContract]
        List<CommingUp> Select_Comming_Phones_one(string VonderCode);
        [OperationContract]
        void Insert_Comming(CommingUp r);
        [OperationContract]
        void Update_Comming(string VonderCode, string NameFirm, CommingUp r);
        [OperationContract]
        void Delete_Comming(string VonderCode);

        [OperationContract]
        void Update_Sending(string VonderCode, string Address, string Status, int id, Sending s);


        [OperationContract]
        List<AdressesShops> Select_AdressesShops();
        [OperationContract]
        void Insert_SendingPhone(Sending s);
        [OperationContract]
        List<Sending> Select_Sending();

        [OperationContract]
        void Insert_AddressNew(AdressesShops r);

        [OperationContract] 
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Добавьте здесь операции служб
    }


    // Используйте контракт данных, как показано в примере ниже, чтобы добавить составные типы к операциям служб.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
