using la_mia_pizzeria_static.Models;
using la_mia_pizzeria_static.Models.Forms;

namespace la_mia_pizzeria_static.Controllers.Repository
{
    public interface InerfacePizzaRepository
    {
        void AddCategory(Category category);
        void AddIngredient(Ingredient ingredient);
        void AddPizza(PizzaForm forms, List<Ingredient> ingredients);
        void UpdatePizza(PizzaForm forms, List<Ingredient> ingredients);
        List<Category> ListCategory();
        List<Ingredient> ListIngredient();
        void UpdateIngredient(int id,Ingredient ingredient);
        List<Pizza> ListPizze();
        void RemoveCategory(int id);
        void RemoveIngredient(int id);
        void RemovePizza(Pizza pizza);
        void UpdateCategory(int id, Category category);
        Category ThisCategory(int id);
        Ingredient ThisIngredient(int id);
        Pizza TihisPizza(int id);
        List<Message> ListMessage();
        Message ThisMessage(int id);
        void UpdateMessage(int id, Message message);
        void RemoveMessage(int id);
    }
}