﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IApplicantService 
    {
        void ApplyForMask(Person person);  //Metot imzası

        List<Person> GetList();

        bool CheckPerson(Person person);
    }
}
