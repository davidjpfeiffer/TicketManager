﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dmn = Domain;
using Dto = Service.Dto;

namespace Service.Converters
{
    public static class MessageConverter
    {
        public static Dto.Message ToDto(Dmn.Message domain)
        {
            return new Dto.Message()
            {
                Id = domain.Id,
                SenderId = domain.SenderId,
                RecipientId = domain.RecipientId,
                Content = domain.Content,
                DateSent = domain.DateSent,
                Sender = domain.Sender.FirstName + ' ' + domain.Sender.LastName
            };
        }
    }
}
