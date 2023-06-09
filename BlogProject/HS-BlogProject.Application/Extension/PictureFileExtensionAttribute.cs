﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS_BlogProject.Application.Extension
{
    public class PictureFileExtensionAttribute : ValidationAttribute
    {
        //Kendi Validation Attributumuz oluşturduk.

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            IFormFile file = (IFormFile)value;  // value as IFormFile  tipini çevirdik.

            if (file is not  null)
            {
                var extension = Path.GetExtension(file.FileName).ToLower();

                string[] extensions = { ".jpg", ".jpeg", ".png" };

                bool result = extensions.Any(x => x.EndsWith(extension));

                if (!result)
                {
                    return new ValidationResult("Valid format is 'jpg', 'jpeg', 'png'");
                }

            }

            return ValidationResult.Success;
        }

    }
}
