using System;
using System.Collections.Generic;
using gregs_list_again.DB;
using gregs_list_again.Models;
using gregs_list_again.Services;
using Microsoft.AspNetCore.Mvc;

namespace gregs_list_again.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController : ControllerBase
    {

        // REVIEW whats going on with next two sections,
        private readonly CarsService _service;

        // dependency injection/transient
        public CarsController(CarsService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Car>> getAll()
        {
            try
            {
                return Ok(FakeDB.Cars);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Car> GetCarById(string id)
        {
            try
            {
                Car found = _service.GetCarById(id);
                return Ok(found);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public ActionResult<Car> CreateCar([FromBody] Car newCar)
        {
            try
            {
                Car car = _service.CreateCar(newCar);
                return Ok(car);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<Car> EditCar([FromBody] Car editCar, string id)
        {
            try
            {
                editCar.Id = id;
                Car car = _service.EditCar(editCar);
                return Ok(car);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Car> DeleteCar(string id)
        {
            try
            {
                _service.DeleteCar(id);
                return Ok("Deleted Successfully");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}