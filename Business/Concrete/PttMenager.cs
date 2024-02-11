using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttMenager : ISuppleirService
    {
        private IApplicantService _applicantService;

        public PttMenager(IApplicantService applicantService) // Constructor(oluşturucu) new yapıldığında bu block önce çalışır
        {
            _applicantService = applicantService;//fieldların _ ile başlamasının sebebi construtorde onu set ederiz

        }
        public void GiveMask(Person person)
        {            
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + "Maske Verildi " );
            }
            else
            {
                Console.WriteLine(person.FirstName + "Maske VERİLEMEDİ! ");
            }
        }
    }
}
