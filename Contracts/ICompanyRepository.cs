﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ICompanyRepository
    {
        // IEnumerable<Company> GetAllCompanies(bool trackChanges);
        Task<IEnumerable<Company>> GetAllCompaniesAsync(bool trackChanges);

        // Company? GetCompany(Guid companyId, bool trackChanges);
        Task<Company?> GetCompanyAsync(Guid companyId, bool trackChanges);

        void CreateCompany(Company company);

        // IEnumerable<Company> GetByIds(IEnumerable<Guid> ids, bool trackChanges);
        Task<IEnumerable<Company>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges);

        void DeleteCompany(Company company);
    }
}
