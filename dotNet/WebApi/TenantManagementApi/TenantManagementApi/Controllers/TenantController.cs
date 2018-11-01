using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using TenantManagementApi.DTOs;
using TenantManagementApi.Models.Login;
using TenantManagementApi.Models.MasterModel;
using TenantManagementApi.Models.Tenant;
using TenantManagementApi.Repository;
using TenantManagementApi.Specification;

namespace TenantManagementApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/tenant")]
    public class TenantController:ApiController
    {
       private  ITenantRepository<User> _tenantRepo = new TenantRepository();

        [Route("AddUser")]
        public IHttpActionResult PostAddUser(UserDTO userDTO)
        {
            List<Module> modules = new List<Module>();
            List<Service> services = new List<Service>();
         


          

            foreach (string modulename in userDTO.subscriptiondetail.Modules)
            {
                modules.Add(new Module {
                    ModuleName = modulename,
                
                });
            }

            foreach (string servicename in userDTO.subscriptiondetail.Services)
            {
                services.Add(new Service
                {
                   ServiceName=servicename

                });
            }


            User user = new User();

            user.Name = userDTO.basicdetail.Name;
            user.Currency = userDTO.basicdetail.Currency;
            user.UserRole = userDTO.basicdetail.UserRole;
            user.WebUrl = userDTO.basicdetail.WebUrl;
            user.ShortName = userDTO.basicdetail.ShortName;

            user.UserAddress = new List<Address>();
            user.UserAddress = ConvertToAddress(userDTO.basicdetail.address);

            user.Contact = new List<ContactDetail>();
            user.Contact = Convert_ToContactDetail(userDTO.basicdetail.contact);
           



            user.UserSubscriptionsDetails = new List<Subscription>();
            user.UserSubscriptionsDetails.Add(new Subscription {
                NoNamedUser = userDTO.subscriptiondetail.NoOfNamedUser,
                Type = userDTO.subscriptiondetail.Type,
                UserModules = modules,
                UserServices=services
                     
            });

            user.UserMasterDetails = new Master();
            user.UserMasterDetails.Modules = new List<Module>();
            user.UserMasterDetails.Servies = new List<Service>();
            user.UserMasterDetails.Partners = new List<Partner>();
            user.UserMasterDetails.Partners.Add(new Partner { PartnerName="Aurinpro"});

            user.UserMasterDetails.Modules = modules;
            user.UserMasterDetails.Servies = services;
            
           


           
            user.LoginDetails = new LoginDetail();
            user.LoginDetails.Username = userDTO.logindetail.Username;
            user.LoginDetails.Password = userDTO.logindetail.Password;
            user.LoginDetails.Captcha = userDTO.logindetail.Captcha;
           
           
           return Ok(_tenantRepo.Add(user));
        }

        [Route("UpdateUser")]
        public IHttpActionResult PostUpadteUser(User user)
        {
            _tenantRepo.Update(user);
            return Ok("User Profile Updated...");
        }

        [Route("DeleteUser/id")]
        public IHttpActionResult DeleteUser(string id)
        {

            _tenantRepo.Delete(Guid.Parse(id));
            return Ok("User Deleted...");
        }

        [Route("GetUser/id")]
        
        public IHttpActionResult GetUserById(string id)
        {
            var user = _tenantRepo.GetById(Guid.Parse(id));
    
            return Ok(GetSingleUser_DTO(user));
        }

        [Route("GetAllUser")]
        public IHttpActionResult GetAllUser()
        {
            var userList = _tenantRepo.GetAll();
            List<BasicDetailDTO> userList_DTO = GetUserList_DTO(userList);
            return Ok(userList_DTO);
        }

        [Route("SearchUserByName/name")]
        public IHttpActionResult GetUserByName(string name)
        {
            var searchCriteris = new UserSearchCriteria();
            searchCriteris.Name = name;

            var searchSpecification = new UserSpecificationForSearch(searchCriteris);


            return Ok(GetUserList_DTO(_tenantRepo.Find(searchSpecification)));

        }



        private BasicDetailDTO GetSingleUser_DTO(User user)
        {
            return new BasicDetailDTO {
                Id = user.Id,
                Currency = user.Currency,
                Name = user.Name,
                ShortName = user.ShortName,
                UserRole = user.UserRole,
                WebUrl = user.WebUrl,
                address = ConvertToAddressDTO(user.UserAddress),
                contact = ConvertTo_ContactDetailDTO(user.Contact)



            };

        }

        private List<BasicDetailDTO> GetUserList_DTO(IList<User> userList)
        {
            List<BasicDetailDTO> UserDTOList = new List<BasicDetailDTO>();


            foreach (User user in userList)
            {
                BasicDetailDTO singleUserDTO = new BasicDetailDTO()
                {
                    Id = user.Id,
                    Currency = user.Currency,
                    Name = user.Name,
                    ShortName = user.ShortName,
                    UserRole = user.UserRole,
                    WebUrl = user.WebUrl

                };

                UserDTOList.Add(singleUserDTO);
            }
            return UserDTOList;
        }

        private List<AddressDetailDTO> ConvertToAddressDTO(List<Address> addresses)
        {
            List<AddressDetailDTO> AddresesDTOList = new List<AddressDetailDTO>();
            foreach (Address singleAddress in addresses)
            {
                AddresesDTOList.Add(new AddressDetailDTO {
                    City=singleAddress.City,
                    Country=singleAddress.Country,
                    State=singleAddress.State,
                    Street=singleAddress.Street,
                    ZipCode=singleAddress.ZipCode
                });
            }
            return AddresesDTOList;
        }


        private List<Address> ConvertToAddress(List<AddressDetailDTO> addresses)
        {
            List<Address> AddressList = new List<Address>();
            foreach (AddressDetailDTO singleAddressDTO in addresses)
            {
                AddressList.Add(new Address {
                    City=singleAddressDTO.City,
                    Country=singleAddressDTO.Country,
                    State=singleAddressDTO.State,
                    Street=singleAddressDTO.Street,
                    ZipCode=singleAddressDTO.ZipCode
                });
            }
            return AddressList;
        }

        private List<ContactDetail> Convert_ToContactDetail(List<ContactDetailDTO> contacts)
        {
            List<ContactDetail> contactsList = new List<ContactDetail>();
            foreach (ContactDetailDTO singleContactDTO in contacts)
            {
                contactsList.Add(new ContactDetail {
                    Email=singleContactDTO.Email,
                    FirstName=singleContactDTO.FirstName,
                     LastName=singleContactDTO.LastName,
                     PhoneNumber=singleContactDTO.PhoneNumber,
                     
                });
            }
            return contactsList;
        }

        private List<ContactDetailDTO> ConvertTo_ContactDetailDTO(List<ContactDetail> contacts)
        {
            List<ContactDetailDTO> contactsDTOLsit = new List<ContactDetailDTO>();

            foreach (ContactDetail singleContact in contacts)
            {
                contactsDTOLsit.Add(new ContactDetailDTO {
                    Email=singleContact.Email,
                    FirstName=singleContact.FirstName,
                    LastName=singleContact.LastName,
                    PhoneNumber=singleContact.PhoneNumber
                });
            }
            return contactsDTOLsit;
        }




       



    }
}