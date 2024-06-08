using Ecommerce_Shop.DataAccess.Repository.IRepository;
using Ecommerce_Shop.Models;
using Ecommerce_Shop.Services.Helper;
using Ecommerce_Shop.Utility;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: api/<CategoryController>
        [HttpGet("GetAllCategory")]
        public async Task<IActionResult> GetAllCategory()
        {
            var obj = _unitOfWork.Category.GetAll();
            await Task.Delay(0);
            return Ok(obj);
        }

        // GET api/<CategoryController>/5
        [HttpGet("GetCategoryById/{id}")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            var obj = _unitOfWork.Category.GetFirstOrDefalut(w=>w.Id==id);
            await Task.Delay(0);
            return Ok(obj);
        }

        // POST api/<CategoryController>
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] VmCategory value)
        {
            if (value.Id != 0)
            {
                return Ok(new { message = "User can not be created" });
            }

            Category category = new Category
            {
                Name = value.Name,
                Status = value.Status,
                CreationDate= BdDateTime.Now(),
                CreatedBy= 0
            };
            await Task.Delay(0);
            _unitOfWork.Category.Add(category);
            _unitOfWork.Save();

            return Ok(new { message = "Category Created Successfully" });
        }


        // PUT api/<CategoryController>/5
        [HttpPut("Edit/{id}")]
        public async Task<IActionResult> Edit(int id, [FromBody] VmCategory value)
        {
            try
            {
                var categoryFromDb = _unitOfWork.Category.GetFirstOrDefalut(u => u.Id == id);
                if (categoryFromDb == null)
                {
                    return NotFound(new { message = "Category not found" });
                }

                categoryFromDb.Name = value.Name;
                categoryFromDb.Status = value.Status;
                categoryFromDb.LastUpdateBy = 0;
                categoryFromDb.LastUpdateDate = BdDateTime.Now();
                 
                await Task.Delay(0); 

                _unitOfWork.Category.Update(categoryFromDb);
                _unitOfWork.Save();

                return Ok(new { message = "Category Updated Successfully" });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = "An error occurred while updating the category", details = ex.Message });
            }
        }


        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
