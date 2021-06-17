﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace TechShopSolution.ViewModels.Catalog.Product.Validator
{
    public class UpdateProductValidator : AbstractValidator<ProductUpdateRequest>
    {
        public UpdateProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Tên sản phẩn không được để trống")
                   .MaximumLength(255).WithMessage("Tên sản phẩm không thể vượt quá 255 kí tự");
            RuleFor(x => x.Slug).NotEmpty().WithMessage("Nhập đường dẫn cho sản phẩm")
                  .MaximumLength(255).WithMessage("Đường dẫn không thể vượt quá 255 kí tự");
            RuleFor(x => x.Unit_price).NotEmpty().WithMessage("Vui lòng nhập giá cho sản phẩm");
            RuleFor(x => x.Brand_id).NotNull().WithMessage("Chưa chọn thương hiệu cho sản phẩm");
            RuleFor(x => x.CateID).NotNull().WithMessage("Chưa chọn loại sản phẩm");
        }
    }
}
