using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TenantManagementApi.Models.Tenant;

namespace TenantManagementApi.Repository
{
    public class TenantRepository : ITenantRepository<User>
    {
        private TenantDbContext _dbContext;

        public TenantRepository()
        {
            _dbContext = new TenantDbContext();
        }
        public Guid Add(User entity)
        {
            _dbContext.Users.Add(entity);
            _dbContext.SaveChanges();
            return entity.Id;
        }

        public int Count(ISpecification<User> specifivation)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid entityId)
        {
            _dbContext.Users.Remove(GetById(entityId));
            _dbContext.SaveChanges();
        }

        public IList<User> Find(ISpecification<User> specification)
        {

            return _dbContext.Users.Where(specification.SearchExpression).ToList();
        }

        public IList<User> GetAll()
        {
            return _dbContext.Users.ToList();
        }

        public User GetById(Guid entityId)
        {
            return _dbContext.Users.Where((u) => u.Id == entityId).SingleOrDefault();
        }

        public void Update(User entity)
        {
            User user = GetById(entity.Id);

            user.Name = entity.Name;
            user.ShortName = entity.ShortName;
            user.UserAddress = entity.UserAddress;
            user.UserMasterDetails = entity.UserMasterDetails;
            user.UserRole = entity.UserRole;
            user.UserSubscriptionsDetails = entity.UserSubscriptionsDetails;
            user.WebUrl = entity.WebUrl;
            user.LoginDetails = entity.LoginDetails;
            user.Contact = entity.Contact;
            user.Currency = entity.Currency;

            _dbContext.SaveChanges();
            

        }
    }
}