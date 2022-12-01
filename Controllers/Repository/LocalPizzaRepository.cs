using la_mia_pizzeria_static.data;
using la_mia_pizzeria_static.Models;
using la_mia_pizzeria_static.Models.Forms;

namespace la_mia_pizzeria_static.Controllers.Repository
{
    public class LocalPizzaRepository : InerfacePizzaRepository
    {
        public static List<Pizza> Pizzas = new();
        public static List<Ingredient> Ingredients = new();
        public static List<Category> Categories = new();
        public static List<Message> Messages = new();


        public LocalPizzaRepository()
        {
        }


        //funzioni DB per pizza
        public Pizza ThisPizza(int id)
        {
            return Pizzas.Where(Pizza => Pizza.Id == id).FirstOrDefault();
        }
        public List<Pizza> ListPizze()
        {
            return Pizzas.ToList();
        }
        public void AddPizza(PizzaForm forms, List<Ingredient> ingredients)
        {
            Pizza newPizza = forms.Pizza;
            newPizza.Category = ThisCategory(forms.Pizza.CategoryId);
            newPizza.Ingredients = new();
            foreach (var item in forms.Ingredients)
            {
                newPizza.Ingredients.Add(item);
            }
            newPizza.CategoryId = forms.Pizza.CategoryId;
            Pizzas.Add(newPizza);
        }
        public void RemovePizza(Pizza pizza)
        {
            Pizzas.Remove(pizza);
        }
        public void UpdatePizza(Pizza pizza, List<Ingredient> ingredients)
        {
            Pizza uploadPizza = pizza;
            uploadPizza.Ingredients = ingredients.ToList();
            uploadPizza.Name = pizza.Name;
            uploadPizza.Description = pizza.Description;
            uploadPizza.ImageAddress = pizza.ImageAddress;
            uploadPizza.Price = pizza.Price;
            uploadPizza.Category = pizza.Category;
            uploadPizza.CategoryId = pizza.CategoryId;
            Pizzas.Remove(pizza);
            Pizzas.Add(uploadPizza);
        }


        //funzioni DB per ingredienti
        public Ingredient ThisIngredient(int id)
        {
            return Ingredients.Where(i => i.Id == id).FirstOrDefault();
        }
        public List<Ingredient> ListIngredient()
        {
            return Ingredients.ToList();
        }
        public void AddIngredient(Ingredient ingredient)
        {
            Ingredients.Add(ingredient);
        }
        public void RemoveIngredient(int id)
        {
            Ingredients.Remove(ThisIngredient(id));
        }
        public void UpdateIngredient(int id, Ingredient ingredient)
        {
            ThisIngredient(id).Name = ingredient.Name;
        }



        //funzioni DB per category
        public Category ThisCategory(int id)
        {
            return Categories.Where(post => post.Id == id).FirstOrDefault();
        }
        public List<Category> ListCategory()
        {
            return Categories.ToList();
        }
        public void AddCategory(Category category)
        {
            Categories.Add(category);
        }
        public void RemoveCategory(int id)
        {
            Categories.Remove(ThisCategory(id));
        }
        public void UpdateCategory(int id, Category category)
        {
            ThisCategory(category.Id).Name = category.Name;
        }

        //funzioni DB per message
        public Message ThisMessage(int id)
        {
            return Messages.Where(post => post.Id == id).FirstOrDefault();
        }
        public List<Message> ListMessage()
        {
            return Messages.ToList();
        }
        public void AddMessages(Message message)
        {
            Messages.Add(message);
        }
        public void RemoveMessage(int id)
        {
            Messages.Remove(ThisMessage(id));
        }
        public void UpdateMessage(int id, Message message)
        {
            //ThisCategory(message.Id).Name = Messages.Name;
        }
    }
}
