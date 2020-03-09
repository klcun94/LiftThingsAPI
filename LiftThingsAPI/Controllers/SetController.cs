using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiftThingsAPI.ApiModels;
using LiftThingsAPI.Core.Models;
using LiftThingsAPI.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LiftThingsAPI.Controllers
{
    [Route("api/[controller]")]
    public class SetController : Controller
    {
        private readonly ISetService _setService;

        public SetController(ISetService setService)
        {
            _setService = setService;
        }

        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_setService.GetAll().ToApiModels());
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("GetSet", ex.StackTrace);
                return BadRequest(ModelState);
            }
        }

        //GET api/routine/id
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(_setService.Get(id).ToApiModel());
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("GetSet", ex.StackTrace);
                return BadRequest(ModelState);
            }
        }

        //POST api/routine
        [HttpPost]
        public IActionResult Post([FromBody] Set set)
        {
            try
            {
                return Ok(_setService.Add(set).ToApiModel());
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("PostSet", ex.StackTrace);
                return BadRequest(ModelState);
            }
        }

        //PUT api/routine/id
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Set set)
        {
            try
            {
                var b = _setService.Update(set).ToApiModel();

                return Ok(b);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("PutSet", ex.StackTrace);
                return BadRequest(ModelState);
            }
        }

        //DELETE api/builder/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _setService.Remove(id);

                return Ok();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("RemoveSet", ex.StackTrace);
                return BadRequest(ModelState);
            }
        }
    }
}
