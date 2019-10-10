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
    [RoutePrefix("api/CareerCloud/jobApplication/v1")]
    public class ApplicantJobApplicationController : ApiController
    {
        private ApplicantJobApplicationLogic _logic;

        public ApplicantJobApplicationController()

        {
            EFGenericRepository<ApplicantJobApplicationPoco> repo = new EFGenericRepository<ApplicantJobApplicationPoco>();
            _logic = new ApplicantJobApplicationLogic(repo);
        }
        [HttpGet]
        [Route("jobApplication/{applicantJobApplicationId}")]
        [ResponseType(typeof(ApplicantJobApplicationPoco))]
        public IHttpActionResult GetApplicantJobApplication(Guid applicantJobApplicationId)
        {
            ApplicantJobApplicationPoco appEdu = _logic.Get(applicantJobApplicationId);
            if (appEdu == null)
            {
                return NotFound();
            }
            return Ok(appEdu);

        }
        [HttpGet]
        [Route("jobApplication")]
        [ResponseType(typeof(List<ApplicantJobApplicationPoco>))]
        public IHttpActionResult GetAllApplicantJobApplication()
        {
            var jobApplications = _logic.GetAll();
            if (jobApplications == null)
            {
                NotFound();
            }
            return Ok(jobApplications);
        }
        [HttpPut]
        [Route("jobApplication")]
        public IHttpActionResult PutApplicantJobApplication([FromBody] ApplicantJobApplicationPoco[] pocos)
        {
            _logic.Update(pocos);

            return Ok();

        }
        [HttpPost]
        [Route("jobApplication")]
        public IHttpActionResult PostApplicantJobApplication([FromBody] ApplicantJobApplicationPoco[] pocos)
        {
            _logic.Add(pocos);

            return Ok();

        }
        [HttpDelete]
        [Route("jobApplication")]
        public IHttpActionResult DeleteApplicantJobApplication([FromBody] ApplicantJobApplicationPoco[] pocos)
        {
            _logic.Delete(pocos);
            return Ok();
        }
    }
}
