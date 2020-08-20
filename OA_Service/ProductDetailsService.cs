﻿using OA_DataAccess;
using OA_Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA_Service
{
    public class ProductDetailsService : IProductDetailsService
    {
        private IRepository<ProductDetails> productDetailsRepository;

        public ProductDetailsService(IRepository<ProductDetails> productDetailsRepository)
        {
            this.productDetailsRepository = productDetailsRepository;
        }

        public ProductDetails GetProductDetail(int id)
        {
            return productDetailsRepository.Get(id);
        }
    }
}
