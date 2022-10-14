using Exam.NET.Dtos;
using Exam.NET.Entities;
using Exam.NET.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Exam.NET.Controllers
{
    [ApiController]
    [Route("items")]
    public class ItemsController : ControllerBase 
    {
        private readonly IItemsRepository repository;
        
        public ItemsController (IItemsRepository repository)
        {
            this.repository = repository;
            
        }


        //ADD
        [HttpPost]
        public ActionResult<ItemDto> AddItem(CreateItemDto itemDto)
        {
            Item item = new(){
                Id = Guid.NewGuid(),
                Name = itemDto.Name,
                UserType = itemDto.UserType,
                Email = itemDto.Email,
                Phone = itemDto.Phone
            };
        }

        //GET
        [HttpGet("{id}")]
        public ActionResult<ItemDto> GetItem()
        {

        }


        //UPDATE
        [HttpPut]
        public ActionResult<ItemDto> UpdateItem();
        {

        }



        //DELETE
        [HttpDelete("{id}")]
        public ActionResult<ItemDto> DeleteItem();
        {

        }


    }
}