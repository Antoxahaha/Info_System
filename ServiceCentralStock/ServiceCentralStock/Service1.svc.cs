using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiceCentralStock
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы Service1.svc или Service1.svc.cs в обозревателе решений и начните отладку.
    public class Service1 : IService1
    {
        public DBComingUpEntities db = new DBComingUpEntities();
        public List<CommingUp> Select_Comming_Phones()
        {
            var query =  db.CommingUp.OrderBy(s => s.NameFirm);
            return query.ToList();
        }
        public List<CommingUp> Select_Comming_Phones_one(string VonderCode)
        {
            var query = db.CommingUp.Where(x => x.VonderCode == VonderCode);
            return query.ToList();
        } 
        public void Insert_Comming(CommingUp r)
        {
            db.CommingUp.Add(r);
            db.SaveChanges();
        } 
        public async void Update_Comming(string VonderCode, string NameFirm, CommingUp r)
        {
            var rou = (from x in db.CommingUp
                       where (x.VonderCode == VonderCode)
                       select x).First();
            rou.NameFirm = r.NameFirm;
            rou.VonderCode = r.VonderCode;
            rou.NameModel = r.NameModel;
            rou.Count = r.Count;
            rou.InStock = r.InStock;
            rou.DMY = r.DMY;
            rou.Price = r.Price;
            await db.SaveChangesAsync();
        }
        public async void Delete_Comming(string VonderCode)
        {
            var rou = (from x in db.CommingUp
                       where (x.VonderCode == VonderCode)
                       select x).First();
            db.CommingUp.Remove(rou); 
            await db.SaveChangesAsync();       
        }
        /////////////////////////////////////////////
        public List<AdressesShops> Select_AdressesShops()
        {  
            var query = db.AdressesShops.OrderBy(s => s.Adress);
            return query.ToList();
        }
        public List<Sending> Select_Sending()
        { 
            var query = db.Sending.OrderBy(s => s.TimeOfSend);
            return query.ToList();
        }
        public  void Insert_AddressNew(AdressesShops r)
        {
            db.AdressesShops.Add(r);
            db.SaveChanges();
        }
        public void Insert_SendingPhone(Sending s)
        {
            db.Sending.Add(s); 
            db.SaveChanges();  
        }
        /////////////////////////////////////////////
        public async void Update_Sending(string VonderCode,string Address, string Status,int id, Sending s)
        {          
            var rou = (from x in db.Sending
                       where (x.VonderCode == VonderCode)
                       where (x.Address == Address)
                       where (x.Status == Status)
                       where (x.Id == id)
                       select x).First();
            rou.NameFirm = s.NameFirm;
            rou.VonderCode = s.VonderCode;
            rou.NameModel = s.NameModel;
            rou.Count = s.Count;
            rou.Address = s.Address;
            rou.Status = s.Status;
            rou.TimeOfSend = s.TimeOfSend;
           await  db.SaveChangesAsync();
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
