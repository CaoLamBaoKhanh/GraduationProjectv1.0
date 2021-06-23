﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace TechShopSolution.ViewModels.Catalog.Customer.Validator
{
    public class CustomerRegisterValidator : AbstractValidator<CustomerRegisterRequest>
    {
        public CustomerRegisterValidator()
        {
            RuleFor(x => x.name).NotEmpty().WithMessage("Tên không được để trống")
                  .MaximumLength(255).WithMessage("Tên không thể vượt quá 255 kí tự");
            RuleFor(x => x.email).NotEmpty().WithMessage("Email không được để trống")
                  .Matches(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").WithMessage("Email không hợp lệ");
            RuleFor(x => x.password).NotEmpty().WithMessage("Mật khẩu không được để trống")
                  .MinimumLength(6).WithMessage("Mật khẩu phải ít nhất 6 kí tự");
            RuleFor(x => x.phone).NotEmpty().WithMessage("Số điện thoại không được để trống")
                  .MinimumLength(10).WithMessage("Số điện thoại phải ít nhất 10 kí tự")
                  .MaximumLength(11).WithMessage("Số điện thoại không vượt quá 11 kí tự")
                  .Must(BeAValidPhone).WithMessage("Vui lòng nhập số điện thoại hợp lệ, VD: 0965349315.")
                  .Must(BeAValidPhone2).WithMessage("Số điện thoại phải bắt đầu bằng số 0");
            RuleFor(x => x.birthday).NotEmpty().WithMessage("Ngày sinh không được để trống")
                  .Must(BeAValidAge).WithMessage("Ngày sinh không hợp lệ");
            RuleFor(x => x.confirmpassword).NotEmpty().WithMessage("Vui lòng Nhập lại mật khẩu");
        }
        protected bool BeAValidAge(DateTime date)
        {
            int currentYear = DateTime.Now.Year;
            int dobYear = date.Year;

            if (dobYear <= currentYear && dobYear > (currentYear - 120))
            {
                return true;
            }

            return false;
        }
        protected bool BeAValidPhone(string phone)
        {
            int n;
            bool isNumeric = int.TryParse(phone, out n);

            return isNumeric;
        }
        protected bool BeAValidPhone2(string phone)
        {
            if (phone.Substring(0, 1).Equals("0"))
                return true;
            return false;
        }
    }
}
