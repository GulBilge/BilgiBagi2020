using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BB2020.Core.Services
{
   public interface IActivityService
    {
        Task<IEnumerable<Activity>> GetActivities();
        Task<Activity> GetActivityById(int id);
        Task<Activity> CreateActivity(Activity newActivity);
        Task UpdateActivity(Activity activityToBeUpdated, Activity activity);
        Task DeleteActivity(Activity activity);
    }
}
