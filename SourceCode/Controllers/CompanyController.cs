using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Mimirium.API.Models;
using Mimirium.API.Service;
using Mimirium.API.Constants;

namespace Mimirium.API.Controllers
{
    [Route(RouteConstants.RouteController)]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly CompanyService service;

        public CompanyController(CompanyService service)
        {
            this.service = service;
        }

        [Route(RouteConstants.HomeApi)]
        [HttpGet]
        public ActionResult<string> Get()
        {
            return Ok(MessageConstants.ApiInformation);
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> GetHome()
        {
            List<Company> customers = service.Get();
            return Ok(customers);
        }

        [Route(RouteConstants.RouteId)]
        [HttpGet]
        public ActionResult<Company> Get(string id)
        {
            var company = service.Get(id);
            if (company == null)
            {
                return NotFound();
            }

            return Ok(company);
        }

        [Route(RouteConstants.PostCompany)]
        [HttpPost]
        public ActionResult<Company> Post([FromBody] Company company)
        {
            service.Create(company);
            return CreatedAtRoute(RouteConstants.GetCompanies, new { id = company.Id.ToString() }, company);
        }

        [Route(RouteConstants.PutCompany)]
        [HttpPut]
        public void Put([FromBody] Company companyIn)
        {
            var currentCustomer = service.Get(companyIn.Id);
            if (currentCustomer != null)
            {
                service.Update(companyIn.Id, companyIn);
            }
        }

        [Route(RouteConstants.RouteName)]
        [Route(RouteConstants.RouteNameWildCard)]
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetByName(string name)
        {
            Company customer = service.GetByName(name);
            return Ok(customer);
        }
    }
}
