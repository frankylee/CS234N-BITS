﻿using System;
using System.Collections.Generic;

namespace bitsEFClasses.Models
{
    public partial class Adjunct
    {
        public int IngredientId { get; set; }
        public int AdjunctTypeId { get; set; }
        public string UseFor { get; set; }
        public double? RecommendedQuantity { get; set; }
        public double? BatchVolume { get; set; }
        public int? RecommendedUseDuringId { get; set; }

        public virtual AdjunctType AdjunctType { get; set; }
        public virtual Ingredient Ingredient { get; set; }
        public virtual UseDuring RecommendedUseDuring { get; set; }
    }
}
