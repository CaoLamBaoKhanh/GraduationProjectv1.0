﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace TechShopSolution.ViewModels.Catalog.Product.Validator
{
    public class CreateProductValidator : AbstractValidator<ProductCreateRequest>
    {
        public CreateProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Tên sản phẩn không được để trống")
                   .MaximumLength(255).WithMessage("Tên sản phẩm không thể vượt quá 255 kí tự");
            RuleFor(x => x.Image).NotNull().WithMessage("Chưa chọn hình ảnh cho sản phẩm");
            RuleFor(x => x.Brand_id).NotNull().WithMessage("Chưa chọn thương hiệu cho sản phẩm");
            RuleFor(x => x.CateID).NotNull().WithMessage("Chưa chọn loại sản phẩm");
            RuleFor(x => x.Warranty).NotEmpty().WithMessage("Vui lòng nhập bảo hành cho sản phẩm");
            RuleFor(x => x.Promotion_price).NotEmpty().WithMessage("Vui lòng nhập giá khuyến mãi cho sản phẩm");
            RuleFor(x => x.Slug).NotEmpty().WithMessage("Nhập đường dẫn cho sản phẩm")
                  .MaximumLength(255).WithMessage("Đường dẫn không thể vượt quá 255 kí tự");
            RuleFor(x => x.Unit_price).NotEmpty().WithMessage("Vui lòng nhập giá cho sản phẩm");
        }
    }
}
