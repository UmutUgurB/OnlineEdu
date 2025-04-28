using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.DTOLayer.DTOs.MessageDtos
{
    public class CreateMessageDto
    {

        public string Name { get; set; }
        public string Subject { get; set; }
        public string MessageContent { get; set; }
        public bool IsMessageActive { get; set; }
    }
}
