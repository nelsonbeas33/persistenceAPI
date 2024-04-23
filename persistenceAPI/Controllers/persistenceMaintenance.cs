using conn;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.db;
using Models.db.postModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace persistenceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class persistenceMaintenance : ControllerBase
    {
        [HttpGet]
        public String Get()
        {
            return "get api persistenceMaintenance";
        }

        [HttpPost]
        public String Post([FromBody] persistenceMaintenanceJson body)
        {

            Maintenance maintenance = new()
            {
                LineElementId = body.line_element_id,
                UserId = 1, //body.user_id,
                Name = body.name,
                Desc = body.desc,
                RootCause = body.root_cause,
                SubCause = body.sub_cause,
                InicialDate = new DateTime(body.date_year, body.date_month, body.date_day),
                FinalDate = null,
                Success = Convert.ToBoolean(body.success)
            };

            mantenimientoContext context = new();
            context.Add(maintenance);
            context.SaveChanges();

            return "get api post";
        }
    } 
}
