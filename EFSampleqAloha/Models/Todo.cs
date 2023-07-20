using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSampleqAloha.Models
{
    public class Todo : BaseModel
    {
        public string TaskName { get; set; }
        public string Description { get; set; }

        public DateTime DueDate { get; set; }

        public int Priority { get; set; }
        public bool Status { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}



//task_id(Primary Key)
//user_id(Foreign Key referencing Users.user_id)
//task_name
//description
//due_date
//priority
//status