using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StartPage.Rest.Models;

namespace StartPage.Rest.Controllers
{
    [Route("api/v1/[controller]")]
    public class BookmarksController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Get()
            => await Task.FromResult(new OkResult());

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id) 
            => await Task.FromResult(new OkResult());

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Bookmark bookmark) 
            => await Task.FromResult(new OkResult());

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody]Bookmark bookmark) 
            => await Task.FromResult(new OkResult());

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
            => await Task.FromResult(new OkResult());
    }
}
