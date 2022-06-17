using System.Transactions;

namespace modul3api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var person = new Person();
            //var studenten = new Student();
            
            
            List<string> backpackcontents = new List<string>();
            backpackcontents.Add("books");
            backpackcontents.Add("laptop");
            backpackcontents.Add("lunch");

            var student = new Student(true,backpackcontents, "navn", 99, "addresse 99", "kjønn");

            foreach (var VARIABLE in student.Backpack)
            {
                Console.WriteLine(VARIABLE);
            }




            /*
              var builder = WebApplication.CreateBuilder(args);
             

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
            */
        }
    }
}