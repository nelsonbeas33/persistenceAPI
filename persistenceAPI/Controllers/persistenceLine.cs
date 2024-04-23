using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using conn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Models.db;
using Models.PostArguments;

namespace persistenceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class persistenceLine : ControllerBase
    {
        [HttpGet]
        public String Get()
        {
            return "get api persistenceLine";
        }

        [HttpPost]
        public String Post([FromBody] persistenceLineJson body)
        {
            Console.WriteLine(body);
            String apiReturnMsj = "post api persistenceLine";
            int integerElementId;

            foreach (LineJsonelement lineElement in body.elements)
            {

                mantenimientoContext context = new();

                //si el id del elemento/linea es numerico, representa un elemeto existente, si no, es uno nuevo o error
                if (int.TryParse(lineElement.Id, out integerElementId))
                {
                    var ExistentLineElement = context.LineElements.FirstOrDefault(e => e.Id == integerElementId);
                    if (ExistentLineElement != null)
                    {
                        if (body.lineId == ExistentLineElement.LineId)
                        {
                            if (lineElement.Top.EndsWith("px") && lineElement.Left.EndsWith("px"))
                            {
                                ExistentLineElement.Top = lineElement.Top;
                                ExistentLineElement.Left = lineElement.Left;
                                context.Update(ExistentLineElement);
                                context.SaveChanges();
                                continue;
                            }
                        }
                    }
                }

                if (lineElement.Id.Length != 0)
                {
                    if (lineElement.Id[0] == 'N')
                    {
                        lineElement.Id = lineElement.Id.Substring(1);
                        
                        if (lineElement.Id.IndexOf('_') != -1)
                        {
                            lineElement.Id = lineElement.Id.Split('_')[0];
                            //despues de las transformaciones hechas anteriormente
                            if (int.TryParse(lineElement.Id, out integerElementId))
                            {
                                if (lineElement.Top.EndsWith("px") && lineElement.Left.EndsWith("px"))
                                {
                                    LineElement newLE = new() { ElementId = integerElementId, LineId = body.lineId, Top = lineElement.Top, Left = lineElement.Left };
                                    context.Add(newLE);
                                    context.SaveChanges();
                                    continue;
                                }
                            }
                        }
                    }
                }
            }

            return apiReturnMsj;
        }
    }
}
