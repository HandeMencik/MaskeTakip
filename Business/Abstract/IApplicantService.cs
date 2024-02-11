using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicantService
    {
        void ApplyForMask(Person person);// imzaları oluştur


        List<Person> GetList(); // buna metodun imzası denir 



        bool CheckPerson(Person person);  // maske alıcak vatandaşın bilgilerini  mernisten (db)kontrol etmek için 
       
    }
}
