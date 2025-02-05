﻿using Microsoft.AspNetCore.Mvc;

namespace SoftwareCatalog.Api.Vendors;

public class VendorConroller : ControllerBase
{
    [HttpGet("/vendors")]
    public ActionResult GetAllVendors()
    {
        var vendors = new List<string>
        {
            "Microsoft",
            "Oracle",
            "Bungie",
            "JetBrains"
        };
        return Ok(vendors);
    }
}
