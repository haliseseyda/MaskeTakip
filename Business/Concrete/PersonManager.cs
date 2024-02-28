using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    //çıplak class kalmasın
    public class PersonManager:IApplicantService
    {
        //encapsulation
        public void ApplyForMask(Person person) //Foksiyon metot prosedür
        {
            
        }

        //bir class sadece özellik yada sadece fonksiyon tutabilir. Solid "S"
        public List<Person> GetList()  //list gelmiyor ise using kontrol et
        {
            return null;  //null tanımlanmamış demek
        }

        public bool CheckPerson(Person person) 
        {
            //mernis kontrol
            KPSPublicSoapClient clint = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return clint.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalIdentity,person.FirstName,person.LastName,person.DateOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
