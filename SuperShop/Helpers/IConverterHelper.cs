﻿using SuperShop.Data.Entities;
using SuperShop.Models;

namespace SuperShop.Helpers
{
    public interface IConverterHelper
    {
        Product ToPrduct(ProductViewModel model, string path, bool isNew );

        ProductViewModel ToProductViewModel( Product product );
    }
}
