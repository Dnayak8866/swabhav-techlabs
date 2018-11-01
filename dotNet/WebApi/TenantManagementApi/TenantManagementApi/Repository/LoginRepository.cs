using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TenantManagementApi.Models.Login;

namespace TenantManagementApi.Repository
{
    public class LoginRepository : ILoginRepository<LoginDetail>
    {
        private TenantDbContext _dbContext = new TenantDbContext();
        public Guid Add(LoginDetail entity)
        {
            _dbContext.LoginDetails.Add(entity);
            _dbContext.SaveChanges();
            return entity.Id;
        }

        public bool AuthenticateUSer(string username, string password)
        {
            var user = _dbContext.LoginDetails.Where((d) => d.Username == username && d.Password == password).SingleOrDefault();
            if (user != null)
            {
                return true;
            }
            return false;
        }

        public int Count(ISpecification<LoginDetail> specifivation)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid entityId)
        {
            _dbContext.LoginDetails.Remove(GetById(entityId));
            _dbContext.SaveChanges();
        }

        public IList<LoginDetail> Find(ISpecification<LoginDetail> specification)
        {
            return _dbContext.LoginDetails.Where(specification.SearchExpression).ToList();
        }

        public IList<LoginDetail> GetAll()
        {

            return _dbContext.LoginDetails.ToList();
        }

        public LoginDetail GetById(Guid entityId)
        {
            return _dbContext.LoginDetails.Where((d) => d.Id == entityId).SingleOrDefault();
        }

        public LoginDetail GetByUserName(string username)
        {
            return _dbContext.LoginDetails.Where((d) => d.Username == username).SingleOrDefault();
        }

        public void Update(LoginDetail entity)
        {
            LoginDetail logindetail = _dbContext.LoginDetails.Where((d) => d.Id == entity.Id).SingleOrDefault();

            logindetail.Password = entity.Password;
            logindetail.UserDetails = entity.UserDetails;
            logindetail.Captcha = entity.Captcha;
            logindetail.Username = entity.Username;

            _dbContext.SaveChanges();
        }
    }
}