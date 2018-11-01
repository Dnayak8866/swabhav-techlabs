using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using TenantManagementApi.DTOs;
using TenantManagementApi.Models.Login;
using TenantManagementApi.Repository;

namespace TenantManagementApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/tenant/LoginDetails")]
    public class LoginController : ApiController
    {
        ILoginRepository<LoginDetail> _loginRepo = new LoginRepository();

        [Route("CheckUser")]
        public IHttpActionResult PostLoginUser(LoginDTO loginDTO)
        {
            if (_loginRepo.AuthenticateUSer(loginDTO.Username, loginDTO.Password))
            {
                return Ok(_loginRepo.GetByUserName(loginDTO.Username).Id);
            }
            return Ok("cancel");
        }

        [Route("DeleteDetail/id")]
        public IHttpActionResult DeleteDetail(string id)
        {
            _loginRepo.Delete(Guid.Parse(id));
            return Ok("LoginDetails Successfully Deleted");
        }

        [Route("GetAllLoginDetails")]
        [ResponseType(typeof(LoginDetailDTO[]))]
        public IHttpActionResult GetAllDetails()
        {
            var logindetails = _loginRepo.GetAll();
            List<LoginDetailDTO> logindetailDTOList = GetLoginDetail_DTOList(logindetails);
         
            return Ok(logindetailDTOList);
        }

        [Route("GetById/id")]
        public IHttpActionResult GetDetailById(string id)
        {
            var LoginDetail = _loginRepo.GetById(Guid.Parse(id));
            LoginDetailDTO singleLoginDetailDTO = GetSingleLoginDetail_DTO(LoginDetail);

            return Ok(singleLoginDetailDTO);
        }

     

        [Route("GetByUserName")]
        public IHttpActionResult GetDetailByUserName(string  username)
        {
            var LoginDetail = _loginRepo.GetByUserName(username);
            LoginDetailDTO singleLoginDetailDTO = GetSingleLoginDetail_DTO(LoginDetail);
            return Ok(singleLoginDetailDTO);
        }

        [Route("UpdateDetail")]
        public IHttpActionResult PostUpdateDetail(LoginDetail logindetail)
        {
            _loginRepo.Update(logindetail);
            return Ok("LoginDetail Successfully updated....");
        }


       
        private LoginDetailDTO GetSingleLoginDetail_DTO(LoginDetail  logindetail)
        {
            return new LoginDetailDTO
            {
                Id = logindetail.Id,
                Username=logindetail.Username,
                Password= logindetail.Password,
                Captcha=logindetail.Captcha
                
            };
        }

        private List<LoginDetailDTO> GetLoginDetail_DTOList(IList<LoginDetail> logindetails)
        {
            List<LoginDetailDTO> logindetailDTOList = new List<LoginDetailDTO>();
           

            foreach (LoginDetail logindetail in logindetails)
            {
                LoginDetailDTO singleLoginDetailDTO = new LoginDetailDTO()
                {
                    Id = logindetail.Id,
                    Username = logindetail.Username,
                    Password = logindetail.Password,
                    Captcha = logindetail.Captcha

                };

                logindetailDTOList.Add(singleLoginDetailDTO);
            }
            return logindetailDTOList;
        }
    }
}