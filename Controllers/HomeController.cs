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
 new ExamQuestion
                {
                    Number = 10,
                    Question = "What is the purpose of using Include() in an Entity Framework Core query?",
                    Answer = "B. Load related Section data together with Students"
                },
 new ExamQuestion
{
    Number = 11,
    Question = "Why should a ViewModel be used in an ASP.NET Core MVC application?",
    Answer = "B. To combine or shape the data specifically needed by the view"
},
 new ExamQuestion
{
    Number = 12,
    Question = "What happens when a navigation property is loaded using Include()?",
    Answer = "A. It loads the related Section navigation property"
},
 new ExamQuestion
{
    Number = 13,
    Question = "What type of validation happens in the browser before a form is submitted?",
    Answer = "B. Client-side validation"
},
 new ExamQuestion
{
    Number = 14,
    Question = "Why is server-side validation still necessary even when client-side validation is used?",
    Answer = "A. Client-side validation can be bypassed"
},
 new ExamQuestion
{
    Number = 15,
    Question = "Which validation rule is important for a Student Number?",
    Answer = "B. Student Number should be unique"
},
 new ExamQuestion
{
    Number = 16,
    Question = "Why are database constraints important?",
    Answer = "A. They protect data integrity even if application-level validation is bypassed"
},
 new ExamQuestion
{
    Number = 17,
    Question = "Why should exceptions be handled in an ASP.NET Core MVC application?",
    Answer = "B. To catch and handle exceptions that may occur during execution"
},
 new ExamQuestion
{
    Number = 18,
    Question = "Which method is commonly used to handle exceptions globally in ASP.NET Core?",
    Answer = "B. UseExceptionHandler()"
},
 new ExamQuestion
{
    Number = 19,
    Question = "What should happen when a requested resource cannot be found?",
    Answer = "B. Display a Not Found (404) response/page"
},
 new ExamQuestion
{
    Number = 20,
    Question = "What is the main benefit of applying database constraints?",
    Answer = "A. Data integrity"
},
            };

            return View(questions);
        }
    }
}