using System;
using Microsoft.AspNetCore.Mvc;


[Route("categories")]
public class CategoryController : ControllerBase
{
    [HttpGet]
    [Route("list")]
    public string FindAllCategories()
    {
        return "ola Mundo";
    }

    [HttpGet]
    [Route("category/{id:Guid}")]
    public string FindOneCategory(Guid id)
    {
        return "teste" + id;
    }
}