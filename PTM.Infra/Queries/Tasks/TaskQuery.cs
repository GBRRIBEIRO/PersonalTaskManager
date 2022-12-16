using PTM.Domain.Tasks;
using PTM.Infra.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTM.Domain.Queries.Tasks
{
    public class TaskQuery
    {
        public List<Work> GetTasks()
        {
            using (var _db = new ApplicationDataContext())
            {
                var Work = _db.Tasks
                    .ToList();
                return Work;
            }
        }

        public Work GetTaskById(Guid taskId)
        {
            using (var _db = new ApplicationDataContext())
            {
                var workdb = _db.Set<Work>();

                return workdb.Find(taskId) ?? null;
            }
        }

        public void AddTask(Work task)
        {
            using (var _db = new ApplicationDataContext())
            {
                _db.Add(task);
            }
        }

        public void UpdateTask(Work task)
        {
            using (var _db = new ApplicationDataContext())
            {
                var _task = GetTaskById(task.Id);
                _task = task;
                _db.Update(_task);
            }
        }

    }
}
