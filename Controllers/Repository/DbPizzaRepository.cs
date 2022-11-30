using la_mia_pizzeria_static.data;
using la_mia_pizzeria_static.Models;
using la_mia_pizzeria_static.Models.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Server;
using static la_mia_pizzeria_static.Controllers.Repository.DbPizzaRepository;

namespace la_mia_pizzeria_static.Controllers.Repository
{
    public class DbPizzaRepository : InerfacePizzaRepository
    {
        private PizzaDB db;

        public DbPizzaRepository()
        {
            db = new PizzaDB();
        }


        //funzioni DB per pizza
        public Pizza TihisPizza(int id)
        {
            return db.Pizze.Where(Pizza => Pizza.Id == id).Include("Category").Include("Ingredients").FirstOrDefault();
        }
        public List<Pizza> ListPizze()
        {
            return db.Pizze.ToList();
        }
        public void AddPizza(PizzaForm forms , List<Ingredient> ingredients)
        {
            Pizza newPizza = forms.Pizza;
            newPizza.Category = ThisCategory(forms.Pizza.CategoryId);
            newPizza.Ingredients = new();
            foreach (var item in ingredients)
            {
                newPizza.Ingredients.Add(item);
            }
            newPizza.CategoryId = forms.Pizza.CategoryId;
            db.Pizze.Add(newPizza);
            db.SaveChanges();
        }
        public void RemovePizza(Pizza pizza)
        {
            
            db.Pizze.Remove(pizza);
            db.SaveChanges();
        }
        public void UpdatePizza(PizzaForm forms, List<Ingredient> ingredients)
        {
            Pizza updatePizza = new();
            updatePizza.Id = forms.Pizza.Id;
            updatePizza.Name = forms.Pizza.Name;
            updatePizza.Description = forms.Pizza.Description;
            updatePizza.ImageAddress = forms.Pizza.ImageAddress;
            updatePizza.Price = forms.Pizza.Price;
            updatePizza.Category = forms.Pizza.Category;
            updatePizza.CategoryId = forms.Pizza.CategoryId;
            updatePizza.Ingredients = new();
            foreach (Ingredient ing in ingredients)
            {
                updatePizza.Ingredients.Add(ing);
            }
            db.Pizze.Update(updatePizza); 
            db.SaveChanges();
        }


        //funzioni DB per ingredienti
        public Ingredient ThisIngredient(int id)
        {
            return db.Ingredientes.Where(i => i.Id == id).FirstOrDefault();
        }
        public List<Ingredient> ListIngredient()
        {
            return db.Ingredientes.ToList();
        }
        public void AddIngredient(Ingredient ingredient)
        {
            db.Ingredientes.Add(ingredient);
            db.SaveChanges();
        }
        public void RemoveIngredient(int id)
        {
            db.Ingredientes.Remove(ThisIngredient(id));
            db.SaveChanges();
        }
        public void UpdateIngredient(int id,Ingredient ingredient)
        {
            ThisIngredient(id).Name = ingredient.Name;
            db.SaveChanges();
        }

        //funzioni DB per category
        public Category ThisCategory(int id)
        {
            return db.Categoryes.Where(post => post.Id == id).FirstOrDefault();
        }
        public List<Category> ListCategory()
        {
            return db.Categoryes.ToList();
        }
        public void AddCategory(Category category)
        {
            db.Categoryes.Add(category);
            db.SaveChanges();
        }
        public void UpdateCategory(int id,Category category)
        {
            ThisCategory(id).Name = category.Name;
            db.SaveChanges();

        }
        public void RemoveCategory(int id)
        {
            db.Categoryes.Remove(ThisCategory(id));
            db.SaveChanges();
        }


        //funzioni DB per message
        public Message ThisMessage(int id)
        {
            return db.messages.Where(mes => mes.Id == id).FirstOrDefault();
        }
        public List<Message> ListMessage()
        {
            return db.messages.ToList();
        }
        public void AddMessages(Message message)
        {
            db.messages.Add(message);
            db.SaveChanges();
        }
        public void UpdateMessage(int id, Message message)
        {
            ThisMessage(id).Name = message.Name;
            db.SaveChanges();

        }
        public void RemoveMessage(int id)
        {
            db.messages.Remove(ThisMessage(id));
            db.SaveChanges();
        }
    }
}
