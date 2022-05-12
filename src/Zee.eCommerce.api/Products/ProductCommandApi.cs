using System;
using Microsoft.AspNetCore.Mvc;

namespace Zee.eCommerce.Api.Products;

[ApiController]
[Route("api/Product")]
public class ProductCommandApi : ControllerBase
{
    #region actions
    [HttpPost("")]
    public async Task<IActionResult> PostAsync()
    {
        
        return new OkResult();
    }
    #endregion

}