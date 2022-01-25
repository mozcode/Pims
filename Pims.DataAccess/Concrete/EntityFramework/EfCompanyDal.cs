using Core.DataAccess.EntityFramework;
using Pims.DataAccess.Abstract;
using Pims.DataAccess.Concrete.EntityFramework.Contexts;
using Pims.Entities.Concrete;
using System;
using System.Linq.Expressions;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Pims.DataAccess.Concrete.EntityFramework
{
    public class EfCompanyDal : EfEntityRepositoryBase<Company, PimContext>, ICompanyDal
    {
        public Company GetByUser(User user)
        {
            using (var context = new PimContext())
            {
                var result = (from company in context.Companies
                             join users in context.Users on company.Id equals users.CompanyId
                             where user.Id == users.Id
                             select company).SingleOrDefault();

                return result;
            }
        }

        public Company GetWGroupByUser(User user)
        {
            using (var context = new PimContext())
            {
                var result = (from company in context.Companies.Include(x => x.CompanyGroup)
                              join users in context.Users on company.Id equals users.CompanyId
                              where user.Id == users.Id
                              select company).SingleOrDefault();

                return result;
            }
        }

        public Company GetWTypeByUser(User user)
        {
            using (var context = new PimContext())
            {
                var result = (from company in context.Companies.Include(x => x.CompanyType)
                              join users in context.Users on company.Id equals users.CompanyId
                              where user.Id == users.Id
                              select company).SingleOrDefault();

                return result;
            }
        }

        public Company GetWTypeWGroupByUser(User user)
        {
            using (var context = new PimContext())
            {
                var result = (from company in context.Companies.Include(x => x.CompanyType).Include(x => x.CompanyGroup)
                              join users in context.Users on company.Id equals users.CompanyId
                              where user.Id == users.Id
                              select company).SingleOrDefault();

                return result;
            }
        }

        public Company GetWType(Expression<Func<Company, bool>> filter)
        {
            using (var context = new PimContext())
            {
                var result = (from company in context.Companies.Include(x => x.CompanyType)
                              join users in context.Users on company.Id equals users.CompanyId
                              select company).SingleOrDefault(filter);

                return result;
            }
        }

        public Company GetWGroup(Expression<Func<Company, bool>> filter)
        {
            using (var context = new PimContext())
            {
                var result = (from company in context.Companies.Include(x => x.CompanyGroup)
                              join users in context.Users on company.Id equals users.CompanyId
                              select company).SingleOrDefault(filter);

                return result;
            }
        }

        public Company GetWTypeWGroup(Expression<Func<Company, bool>> filter)
        {
            using (var context = new PimContext())
            {
                var result = (from company in context.Companies.Include(x => x.CompanyGroup).Include(x => x.CompanyType)
                              join users in context.Users on company.Id equals users.CompanyId
                              select company).SingleOrDefault(filter);

                return result;
            }
        }
    }
}
