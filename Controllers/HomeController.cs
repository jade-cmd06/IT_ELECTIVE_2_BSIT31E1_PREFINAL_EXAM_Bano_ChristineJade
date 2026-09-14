using IT_ELECTIVE_2_PREFINAL_EXAM.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_2_PREFINAL_EXAM.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var questions = new List<ExamQuestion>
            {
                new ExamQuestion
                {
                    Number = 1,
                    Question = "What is the main problem solved by using a database instead of an in-memory collection?",
                    Answer = "C. It allows data to persist after the application stops"
                },

                new ExamQuestion
                {
                    Number = 2,
                    Question = "Which approach is being used when an existing database is used to generate EF Core entity classes?",
                    Answer = "B. Database-First"
                },

                new ExamQuestion
                {
                    Number = 3,
                    Question = "What is the primary purpose of Entity Framework Core?",
                    Answer = "C. To map objects in code to relational database data"
                },
                new ExamQuestion
{
    Number = 4,
    Question = "Which class is responsible for managing database connections and tracking changes in Entity Framework Core?",
    Answer = "A. DbContext"
},

new ExamQuestion
{
    Number = 5,
    Question = "What does the Scaffold-DbContext command do?",
    Answer = "C. Generates EF Core models and a DbContext from an existing database"
},
new ExamQuestion
{
    Number = 6,
    Question = "Where is the database connection string commonly stored in an ASP.NET Core MVC application?",
    Answer = "B. appsettings.json"
},
new ExamQuestion
{
    Number = 7,
    Question = "What type of relationship allows one Section to have many Students?",
    Answer = "B. One-to-Many"
},
new ExamQuestion
{
    Number = 8,
    Question = "Which key is used to connect a Student record to the Section table?",
    Answer = "B. Foreign key referencing Section"
},
new ExamQuestion
{
    Number = 9,
    Question = "What does a foreign key represent in a relational database?",
    Answer = "B. It represents a relationship to another entity"
},
            };

            return View(questions);
        }
    }
}