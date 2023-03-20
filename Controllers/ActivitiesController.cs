using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    [Route("api/[controller]")]

    public class ActivitiesController : BaseApiController
    {
        private readonly DataContext context;
        public ActivitiesController(DataContext context)
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