using System;
using System.Collections.Generic;
namespace Capstone.WebApi.Models
{      
        public class ProductRecommendation
        {
            public bool active { get; set; }
            public int stockCode { get; set; }
            public List<Recommendation> recommendations { get; set; }
        }

        public class Recommendation
        {
            public int stockCode { get; set; }
            public int score { get; set; }
        }

        public class SmartSubsReturn
        {
            public List<ProductRecommendation> productRecommendations { get; set; }
        }
}


