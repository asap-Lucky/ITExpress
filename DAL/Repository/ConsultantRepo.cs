﻿using Abstraction.Interfaces;
using DAL.Database;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class ConsultantRepo : IConsultantRepo
    {
        private ITExpressDataClassesDataContext DataContext { get; set; }

        public ConsultantRepo()
        {
            DataContext = new ITExpressDataClassesDataContext();
        }

        public List<IConsultant> GetAllConsultants()
        {
            var result = new List<IConsultant>();

            var AllDtoItem = DataContext.Consultants;

            foreach (var dto in AllDtoItem) 
            { 
                Models.Consultant consultant = new Models.Consultant();

                consultant.Id = dto.ConsultantId;
                consultant.FirstName = dto.Consultant_FirstName;
                consultant.LastName = dto.Consultant_LastName;
                consultant.Login = dto.Consultant_Login;
                consultant.Password = dto.Consultant_Password;
                consultant.Email = dto.Consultant_Email;
                consultant.ZipCode = dto.Consultant_ZipDode;
                consultant.Address = dto.Consultant_Address;
                consultant.PhoneNumber = dto.Consultant_PhoneNumber;

                result.Add(consultant);
            }
            return result;
        }

        public void AddConsultant(IConsultant dto)
        {
            var con = new Database.Consultant()
            {
                ConsultantId = dto.Id,
                Consultant_FirstName = dto.FirstName,
                Consultant_LastName = dto.LastName,
                Consultant_Login = dto.Login,
                Consultant_Password = dto.Password,
                Consultant_Email = dto.Email,
                Consultant_Address = dto.Address,
                Consultant_ZipDode = dto.ZipCode,
                Consultant_PhoneNumber = dto.PhoneNumber,
            };
            DataContext.Consultants.InsertOnSubmit(con);
            DataContext.SubmitChanges();
        }

        public void DeleteConsultant(IConsultant dto)
        {
            var targetConsultant = DataContext.Consultants.FirstOrDefault(i => i.ConsultantId == dto.Id);

            DataContext.Consultants.DeleteOnSubmit(targetConsultant);

            DataContext.SubmitChanges();
        }

        public void EditConsultant(IConsultant consultant)
        {
            var targetConsultant = DataContext.Consultants.FirstOrDefault(c => c.ConsultantId == consultant.Id);
            if (targetConsultant != null)
            {
                // Update the Consultant object with the new values.
                targetConsultant.Consultant_Address = consultant.Address;
                targetConsultant.Consultant_PhoneNumber = consultant.PhoneNumber;
                targetConsultant.Consultant_FirstName = consultant.FirstName;
                targetConsultant.Consultant_LastName = consultant.LastName;
                targetConsultant.Consultant_Address = consultant.Address;
                targetConsultant.Consultant_ZipDode = consultant.ZipCode;
                targetConsultant.Consultant_Password = consultant.Password;
                targetConsultant.Consultant_Login = consultant.Login;

                // Save the changes to the database.
                DataContext.SubmitChanges();
            }
        }
    }
}
