﻿using Abstraction.Interfaces;
using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class MessageRepo : IMessageRepo 
    {
        private ITExpressDataClassesDataContext DataContext { get; set; }

        public MessageRepo()
        {
            DataContext = new ITExpressDataClassesDataContext();
        }

        public List<IMessage> GetAllMessages()
        {
            var result = new List<IMessage>();

            var AllDtoItem = DataContext.Messages;

            foreach (var dto in AllDtoItem)
            {            
                result.Add(MapToModel(dto));
            }
            return result;
        }

        public void Addmessage(IMessage dto)
        {
            Database.Message messageData = MapToData(dto);
            DataContext.Messages.InsertOnSubmit(messageData);
            DataContext.SubmitChanges();
        }

        public void DeleteMessage(IMessage dto)
        {
            var targetMessage = DataContext.Messages.FirstOrDefault(i => i.MessageId == dto.MessageId);

            DataContext.Messages.DeleteOnSubmit(targetMessage);

            DataContext.SubmitChanges();
        }

    

        public List<IMessage> GetMessagesByCostumer(IMessage message)
        {
            List<IMessage> messageModels = new List<IMessage>();
            var dataMessages = DataContext.Messages.Where(m => m.Message_CustomerId == message.Customer.Id).ToList();
            foreach (var dataMessage in dataMessages)
            {
                messageModels.Add(MapToModel(dataMessage));
            }
            return messageModels;
        }

        private IMessage MapToModel(Database.Message messageData)
        {
            Models.Message messageModel = new Models.Message()
            {
                MessageId = messageData.MessageId,
                Header = messageData.Message_Header,
                Body = messageData.Message_Content,
                Customer = new Models.Customer()
                {
                    Id = messageData.Customer.CustomerId,
                    FirstName = messageData.Customer.Customer_FirstName,
                    LastName = messageData.Customer.Customer_LastName,
                    Login = messageData.Customer.Customer_Login,
                    Password = messageData.Customer.Customer_Password,
                    Email = messageData.Customer.Customer_Email,
                    Address = messageData.Customer.Customer_Address,
                    ZipCode = messageData.Customer.Customer_ZipCode,
                    City = messageData.Customer.Customer_City,
                    PhoneNumber = messageData.Customer.Customer_PhoneNumber
                },
                Consultant = new Models.Consultant()
                {
                    Id = messageData.Consultant.ConsultantId,
                    FirstName = messageData.Consultant.Consultant_FirstName,
                    LastName = messageData.Consultant.Consultant_LastName,
                    Login = messageData.Consultant.Consultant_Login,
                    Password = messageData.Consultant.Consultant_Password,
                    Email = messageData.Consultant.Consultant_Email,
                    ZipCode = messageData.Consultant.Consultant_ZipCode,
                    City = messageData.Consultant.Consultant_City,
                    Address = messageData.Consultant.Consultant_Address,
                    PhoneNumber = messageData.Consultant.Consultant_PhoneNumber,
                    Language = new Models.CodeLanguage()
                    {
                        Id = messageData.Consultant.CodeLanguage.Id,
                        Language = messageData.Consultant.CodeLanguage.LanguageName
                    },
                    EndType = new Models.EndType()
                    {
                        Id = messageData.Consultant.EndType.Id,
                        EndType1 = messageData.Consultant.EndType.EndType1
                    }
                }
            };
            return messageModel;
        }        
        private Database.Message MapToData(IMessage messageModel)
        {
            Database.Message messageData = new Database.Message()
            {
                MessageId = messageModel.MessageId,
                Message_Header = messageModel.Header,
                Message_Content = messageModel.Body,
                Message_CustomerId = messageModel.Customer.Id,
                Message_ConsultantId = messageModel.Consultant.Id
            };
            return messageData;
        }

        public void AddMessage(IMessage dto)
        {
            throw new NotImplementedException();
        }

        public void EditMessage(IMessage message)
        {
            throw new NotImplementedException();
        }
    }
}
