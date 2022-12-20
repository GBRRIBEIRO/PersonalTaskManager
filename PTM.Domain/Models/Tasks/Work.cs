using PTM.Domain.Core;
using PTM.Domain.DTOs.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTM.Domain.Tasks
{
    public class Work
    {
        public Guid Id { get; set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime CreatedOn { get; private set; }
        public DateTime StartDateTime { get; private set; }
        public DateTime FinishedDateTime { get; private set; }
        public int Status { get; private set; } 

        public Work
            (
            string title,
            string description,
            DateTime startDateTime,
            DateTime finishedDateTime,
            int status
            )
        {
            Id = new Guid();
            Title = title;
            Description = description;
            StartDateTime = startDateTime;
            FinishedDateTime = finishedDateTime;
            Status = 1;
        }

        public Work(TaskDTO dto)
        {
            Id = new Guid();
            CreatedOn = DateTime.Now;
            Title = dto.Title;
            Description = dto.Description;
            StartDateTime = dto.StartDateTime;
            FinishedDateTime = dto.FinishedDateTime;
            Status = 0;
        }
    }
}
