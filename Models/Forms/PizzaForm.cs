﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace la_mia_pizzeria_static.Models.Forms
{
    public class PizzaForm
    {
        public Pizza Pizza { get; set; }
        public List<Category>? Categories { get; set; }

        public List<Ingredient>? Ingredients { get; set; }
        public List<int>? SelectIngredient { get; set; }

    }
}
