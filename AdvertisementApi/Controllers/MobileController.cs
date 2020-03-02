using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Repositories;
using DataLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace MobilePhonesearchApi.Controllers
{

    [Route("api/[controller]/")]
    [ApiController]
    public class MobileController : ControllerBase
    {
        private readonly IMobileRepository<MobilePhone> _mobileRepository;


        public MobileController(IMobileRepository<MobilePhone> mobileRepository)
        {
            _mobileRepository = mobileRepository;
        }

        // GET api/Mobile
        [HttpGet]
        public ActionResult Get()
        {
            IEnumerable<MobilePhone> mobilePhones = _mobileRepository.Get();

            return Ok(mobilePhones);
        }
    }
}