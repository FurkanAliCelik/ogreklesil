using ogr.Data.Entities.Responses;
using ogr.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TulparBasicRepositories;

namespace ogr.Data.Services
{
    public class GirisService : Repository<Giris>
    {

        public GirisService(OgrwebContext context) : base(context)
        {
                
        }

        public async Task<bool> Deneme()
        {
            var a =   FindAll(x => x.Username == "Furkan" || x.Password == "1234").ToList();
            var list = GetAll().ToList();

          //  var yeniKayit = new Giris()
          //  {

          //     // Id = Guid.NewGuid,
          //     // Password = "12121",
          //     // Username = "assd"
          //};

          //  await CreateAsync(yeniKayit);

            return false;
        }

        //public async Task<DataResponse<Giris>> AddUser (Giris giris)
        //{
        //    return await 
        //}
    }
}
