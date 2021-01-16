using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace UASPAT_115_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string Administrasi(string IDPemesanan, string NamaCustomer, string No_telpon)
        {
            throw new NotImplementedException();
        }

        public string CalonKaryawan(string IDPemesanan, string NamaCustomer, string NoTelepon, int JumlahPemesanan, string IDLokasi)
        {
            throw new NotImplementedException();
        }

        public List<DataRegister> DataRegist()
        {
            throw new NotImplementedException();
        }

        public string DeleteRegister(string username)
        {
            throw new NotImplementedException();
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public string Interview(string IDPemesanan)
        {
            throw new NotImplementedException();
        }

        public List<DetailLokasi> ListaAdministrasi()
        {
            throw new NotImplementedException();
        }

        public List<Pemesanan> ListInterview()
        {
            throw new NotImplementedException();
        }

        public List<CekLokasi> ListKaryawan()
        {
            throw new NotImplementedException();
        }

        public string Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public string Register(string username, string password, string kategori)
        {
            throw new NotImplementedException();
        }

        public string UpdateRegister(string username, string password, string kategori, int id)
        {
            throw new NotImplementedException();
        }
    }
}
