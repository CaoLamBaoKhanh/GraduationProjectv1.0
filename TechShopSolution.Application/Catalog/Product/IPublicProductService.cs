﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechShopSolution.ViewModels.Catalog.Product;
using TechShopSolution.Application.DTO;

namespace TechShopSolution.Application.Catalog.Product
{
    public interface IPublicProductService
    {
       Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetPublicProductPagingRequest request);
        Task<List<ProductViewModel>> GetAll();

    }
}
