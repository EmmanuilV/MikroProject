// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// //using MyAirport.Models;

// namespace MyAirport.Controllers
// {
//     [Route("api/[controller]")]
//     [ApiController]
//     public class MyAirportController : ControllerBase
//     {
//         public MyAirportController()
//         {
//         }

//         [HttpGet("")]
//         public async Task<ActionResult<IEnumerable<TModel>>> GetTModels()
//         {
//             // TODO: Your code here
//             await Task.Yield();

//             return new List<TModel> { };
//         }

//         [HttpGet("{id}")]
//         public async Task<ActionResult<TModel>> GetTModelById(int id)
//         {
//             // TODO: Your code here
//             await Task.Yield();

//             return null;
//         }

//         [HttpPost("")]
//         public async Task<ActionResult<TModel>> PostTModel(TModel model)
//         {
//             // TODO: Your code here
//             await Task.Yield();

//             return null;
//         }

//         [HttpPut("{id}")]
//         public async Task<IActionResult> PutTModel(int id, TModel model)
//         {
//             // TODO: Your code here
//             await Task.Yield();

//             return NoContent();
//         }

//         [HttpDelete("{id}")]
//         public async Task<ActionResult<TModel>> DeleteTModelById(int id)
//         {
//             // TODO: Your code here
//             await Task.Yield();

//             return null;
//         }
//     }
// }