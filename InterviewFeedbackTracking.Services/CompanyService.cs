using InterviewFeedbackTracking.Data;
using InterviewFeedbackTracking.Models.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewFeedbackTracking.Services
{
    public class CompanyService
    {
        private readonly Guid _userId;

        public CompanyService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateCompany(CompanyCreate company)
        {
            var entity = new Company()
            {
                Name = company.Name,
                Industry = company.Industry,
                CreatedDate = DateTime.Now,
                Website = company.Website,
                StreetAddress = company.StreetAddress,
                City = company.City,
                State = company.State,
                Zip = company.Zip
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Companies.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<CompanyListItem> GetCompanies()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Companies
                    .OrderBy(e => e.Name)
                    .Select(
                        e =>
                        new CompanyListItem
                        {
                            Name = e.Name,
                            Industry = e.Industry,
                            City = e.City,
                            State = e.State,
                            Website = e.Website
                        }
                        );
                return query.ToArray();
            }
        }

        public CompanyDetail GetCompanyById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Companies
                    .Single(e => e.CompanyId == id);
                return
                    new CompanyDetail
                    {
                        Name = entity.Name,
                        StreetAddress = entity.StreetAddress,
                        City = entity.City,
                        State = entity.State,
                        Zip = entity.Zip,
                        Industry = entity.Industry,
                        CreatedDate = entity.CreatedDate,
                        ModifiedDate = entity.ModifiedDate,
                        Website = entity.Website,
                        CompanyId = entity.CompanyId,
                    };
            }
        }

        public bool UpdateCompany(CompanyEdit company) // need to decide if companyedit will hold the id or if the id is separate entity (usually part of in mvc)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Companies
                    .Single(e => e.CompanyId == company.CompanyId);
                entity.City = company.City;
                entity.Industry = company.Industry;
                entity.ModifiedDate = DateTime.Now;
                entity.Name = company.Name;
                entity.State = company.State;
                entity.StreetAddress = company.StreetAddress;
                entity.Zip = company.Zip;
                entity.Website = company.Website;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteCompany(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Companies
                    .Single(e => e.CompanyId == id);

                ctx.Companies.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
