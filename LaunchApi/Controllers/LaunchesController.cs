using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LaunchApi.Models;

namespace LaunchApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class LaunchesController : ControllerBase
  {
    private readonly LaunchApiContext _db;

    public LaunchesController(LaunchApiContext db)
    {
      _db = db;
    }

    [HttpGet()]
    public async Task<ActionResult<IEnumerable<Launch>>> Get(string mission, string location, int daysToLaunch)
    {
      var query = _db.Launches.AsQueryable();

      if (mission != null)
      {
        query = query.Where(entry => entry.Mission == mission);
      }

      if (location != null)
      {
        query = query.Where(entry => entry.Location == location);
      } 

      if (daysToLaunch > 0)
      {
        query = query.Where(entry => entry.DaysToLaunch == daysToLaunch);
      }

      return await query.ToListAsync();
    }

        private bool LaunchExists(int id)
    {
      return _db.Launches.Any(e => e.LaunchId == id);
    }

  }
}