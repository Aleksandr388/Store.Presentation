﻿using Store.BusinessLogic.Models.PrintingEditions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.BusinessLogic.Services.Interfaces
{
    public interface IPrintingEditionService
    {
        public Task CreateAsync(PrintingEditionModel model);
        public Task UpdateAsync(PrintingEditionModel model);
        public Task DeleteAsync(PrintingEditionModel model);
        public Task<PrintingEditionModel> GetByIdAsync(long id);
        public Task<IEnumerable<PrintingEditionModel>> GetAllAsync();
    }
}
