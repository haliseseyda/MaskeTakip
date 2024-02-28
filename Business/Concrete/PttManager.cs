using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PttManager:ISupplierService  //Solid --> o harfi özellik gelirse mevcut kodlara dokunmamak
    {
        private IApplicantService _applicantService;  //Field //tasarım deseni
        //applicant --> aday
        public PttManager(IApplicantService applicantService) //Constructor --> oluşturucu new yapıldığında çalışır
        {
            _applicantService = applicantService;
        }

        public void GiveMask(Person person) 
        {
            //PersonManager personManager = new PersonManager();
            //interfaceler newlenemez referans tutucudurlar
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + "için maske verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName + "için maske VERİLEMEDİ");
            }
        }
    }
}
