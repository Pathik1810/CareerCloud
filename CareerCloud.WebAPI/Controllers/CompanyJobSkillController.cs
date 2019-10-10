﻿using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace CareerCloud.WebAPI.Controllers
{
    [RoutePrefix("api/CareerCloud/company/v1")]
    public class CompanyJobSkillController : ApiController
    {
        private CompanyJobSkillLogic _logic;

        public CompanyJobSkillController()

        {
            EFGenericRepository<CompanyJobSkillPoco> repo = new EFGenericRepository<CompanyJobSkillPoco>();
            _logic = new CompanyJobSkillLogic(repo);
        }
        [HttpGet]
        [Route("jobSkill/{companyJobSkillId}")]
        [ResponseType(typeof(CompanyJobSkillPoco))]
        public IHttpActionResult GetCompanyJobSkill(Guid companyJobSkillId)
        {
            CompanyJobSkillPoco appEdu = _logic.Get(companyJobSkillId);
            if (appEdu == null)
            {
                return NotFound();
            }
            return Ok(appEdu);

        }
        [HttpGet]
        [Route("jobSkill")]
        [ResponseType(typeof(List<CompanyJobSkillPoco>))]
        public IHttpActionResult GetAllCompanyJobSkill()
        {
            var companys = _logic.GetAll();
            if (companys == null)
            {
                NotFound();
            }
            return Ok(companys);
        }
        [HttpPut]
        [Route("jobSkill")]
        public IHttpActionResult PutCompanyJobSkill([FromBody] CompanyJobSkillPoco[] pocos)
        {
            _logic.Update(pocos);

            return Ok();

        }
        [HttpPost]
        [Route("jobSkill")]
        public IHttpActionResult PostCompanyJobSkill([FromBody] CompanyJobSkillPoco[] pocos)
        {
            _logic.Add(pocos);

            return Ok();

        }
        [HttpDelete]
        [Route("jobSkill")]
        public IHttpActionResult DeleteCompanyJobSkill([FromBody] CompanyJobSkillPoco[] pocos)
        {
            _logic.Delete(pocos);
            return Ok();
        }
    }
}
