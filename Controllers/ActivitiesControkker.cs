using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class ActivitiesControkker : BaseApiController
    {
        private readonly DataContext context;
        public ActivitiesControkker(DataContext context)
        {
            this.context = context;

        }


        [HttpGet] // api/activities
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            return await context.Activities.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivity(Guid id){
        
            return await context.Activities.FindAsync(id);
        }
    }
}