﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechShopSolution.ViewModels.Catalog.Category;
using TechShopSolution.ViewModels.Common;

namespace TechShopSolution.Application.Catalog.Category
{
    public interface ICategoryService
    {
        Task<PagedResult<CategoryViewModel>> GetAllPaging(GetCategoryPagingRequest request);
        Task<ApiResult<bool>> Create(CreateCategoryRequest request);
    }
}
