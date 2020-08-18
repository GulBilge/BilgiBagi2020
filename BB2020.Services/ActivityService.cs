using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BB2020.Core;
using BB2020.Core.Services;

namespace BB2020.Services
{
    public class ActivityService : IActivityService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ActivityService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<Activity> CreateActivity(Activity newActivity)
        {
            await _unitOfWork.Activities.AddAsync(newActivity);
            await _unitOfWork.CommitAsync();
            return newActivity;
        }

        public async Task DeleteActivity(Activity activity)
        {
             _unitOfWork.Activities.Remove(activity);
            await _unitOfWork.CommitAsync();
            
        }

        public async Task<IEnumerable<Activity>> GetActivities()
        {
            return await _unitOfWork.Activities.GetAllAsync();
        }

        public async Task<Activity> GetActivityById(int id)
        {
            return await _unitOfWork.Activities.GetByIdAsync(id);
        }

        public async Task UpdateActivity(Activity activityToBeUpdated, Activity activity)
        {
            activityToBeUpdated.ActivityDate = activity.ActivityDate;
            activityToBeUpdated.Description = activity.Description;
            activityToBeUpdated.GroupId = activity.GroupId;
            activityToBeUpdated.Place = activity.Place;
            activityToBeUpdated.Title = activity.Title;
           await _unitOfWork.CommitAsync();
        }
    }
}
