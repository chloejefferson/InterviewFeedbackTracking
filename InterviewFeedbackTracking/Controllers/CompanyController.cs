using InterviewFeedbackTracking.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace InterviewFeedbackTracking.Controllers
{
    //[Authorize] // ambiguous between webmvc and web.http
    public class CompanyController : Controller
    {
        // GET: Company
        public ActionResult Index()
        {
            return View();
        }

        //going to build out as an API first....?
        //Had to add webApi.Core package because this is an mvc, but there are a bunch of errors like not recognizing Ok, BadRequest and InternalServerError. Probably because this is an MVC app.

        //    private CompanyService CreateCompanyService()
        //    {
        //        var userId = Guid.Parse(User.Identity.GetUserId());
        //        var companyService = new CompanyService(userId);
        //        return companyService;
        //    }

        //    public IHttpActionResult Get()
        //    {
        //        CompanyService companyService = CreateCompanyService();
        //        var companies = companyService.GetCompanies();
        //        return Ok(companies);
        //    }

        //    public IHttpActionResult Post(CompanyCreate company)
        //    {
        //        if (!ModelState.IsValid)
        //            return BadRequest(ModelState);

        //        var service = CreateCompanyService();

        //        if (!service.CreateCompany(company))
        //            return InternalServerError();

        //        return Ok();
        //    }

        //    public IHttpActionResult Put(CompanyEdit company)
        //    {
        //        if (!ModelState.IsValid)
        //            return BadRequest(ModelState);

        //        var service = CreateCompanyService();

        //        if (!service.UpdateCompany(company))
        //            return InternalServerError();

        //        return Ok();
        //    }


        //    public IHttpActionResult Delete(int companyId)
        //    {
        //        var companyService = CreateCompanyService();

        //        if (!companyService.DeleteCompany(companyId))
        //            return InternalServerError();

        //        return Ok();
        //    }       
    }
}