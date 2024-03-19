﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator: AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(prop => prop.CategoryId == 1);
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Üürünlerin Adı A Harfi İle Başlamalı!"); //kendi kuralımızı yazarsak ampulden generic ettikten sonra
            
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}