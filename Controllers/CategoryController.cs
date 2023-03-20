﻿using Blog.Data;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class CategoryController : ControllerBase
    {
        [HttpGet("categories")]
        public IActionResult Get([FromServices] BlogDataContext context)
        {
            return Ok(context.Categories.ToList());
        }
    }
}
