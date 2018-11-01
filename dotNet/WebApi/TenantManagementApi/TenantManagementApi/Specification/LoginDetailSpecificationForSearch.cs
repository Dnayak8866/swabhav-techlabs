using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using TenantManagementApi.Models.Login;
using TenantManagementApi.Repository;

namespace TenantManagementApi.Specification
{
    public class LoginDetailSpecificationForSearch : ISpecification<LoginDetail>
    {
        private LoginDetailSearchCriteria _criteria;
        public LoginDetailSpecificationForSearch(LoginDetailSearchCriteria criteria)
        {
            _criteria = criteria;
        }
        public Expression<Func<LoginDetail, bool>> SearchExpression
        {
            get
            {
                Expression<Func<LoginDetail, bool>> query = null;
                if (_criteria.Username != string.Empty)
                {
                    query = (x) => x.Username == _criteria.Username;
                    
                }

                if (_criteria.Id != Guid.Empty)
                {
                    query = (x) => x.Id == _criteria.Id;
                }

                return query;
            }
        }
    }
}