using HakanKabanOdevWeek2.Core.Model;
using HakanKabanOdevWeek2.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HakanKabanOdevWeek2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly IGamesService _service;

        public GamesController(IGamesService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllGames()
        {
            var games = await _service.GetAllAsync();
            return Ok(games);
        }   
        [HttpPost]
        public async Task<IActionResult> Save(Games games)
        {
            var addGames = await _service.AddAsync(games);
            return Ok(addGames);
        }
        [HttpPut]
        public async Task<IActionResult> Update(Games games)
        {
             await _service.UpdateAsync(games);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var games = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(games);

            return Ok();
        }
    }
}
