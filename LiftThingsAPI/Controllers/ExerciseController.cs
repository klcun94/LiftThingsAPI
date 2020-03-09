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
    public class ExerciseController : Controller
    {
        private readonly IExerciseService _exerciseService;

        public ExerciseController(IExerciseService exerciseService)
        {
            _exerciseService = exerciseService;
        }

        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_exerciseService.GetAll().ToApiModels());
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("GetExercise", ex.StackTrace);
                return BadRequest(ModelState);
            }
        }

        //GET api/routine/id
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(_exerciseService.Get(id).ToApiModel());
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("GetExercise", ex.StackTrace);
                return BadRequest(ModelState);
            }
        }

        //POST api/routine
        [HttpPost]
        public IActionResult Post([FromBody] Exercise exercise)
        {
            try
            {
                return Ok(_exerciseService.Add(exercise).ToApiModel());
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("PostExercise", ex.StackTrace);
                return BadRequest(ModelState);
            }
        }

        //PUT api/routine/id
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Exercise exercise)
        {
            try
            {
                var b = _exerciseService.Update(exercise).ToApiModel();

                return Ok(b);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("PutExercise", ex.StackTrace);
                return BadRequest(ModelState);
            }
        }

        //DELETE api/routine/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _exerciseService.Remove(id);

                return Ok();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("RemoveExercise", ex.StackTrace);
                return BadRequest(ModelState);
            }
        }
    }
}
