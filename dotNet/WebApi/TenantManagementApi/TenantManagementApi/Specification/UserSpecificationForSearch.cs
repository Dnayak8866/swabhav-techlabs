using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using TenantManagementApi.Models.Tenant;
using TenantManagementApi.Repository;

namespace TenantManagementApi.Specification
{
    public class UserSpecificationForSearch:ISpecification<User>
    {
        private UserSearchCriteria _criteria;

        public UserSpecificationForSearch(UserSearchCriteria criteria)
        {
            _criteria = criteria;
        }

        public Expression<Func<User, bool>> SearchExpression
        {
            get
            {
                Expression<Func<User, bool>> query = null;
                if (_criteria.Name != string.Empty)
                {
                    query = (x) => x.Name == _criteria.Name;
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