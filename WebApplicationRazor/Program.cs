using WebApplicationRazor.Models.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddTransient<INewsService, NewsService>(); // Реєстрація сервісу новин в контейнері залежностей

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();


/*
 * 1.
 * Створити сторінку про себе (About Me)
 * Додати зображення, коротку біографію, інтереси та контактну інформацію.
 * 
 * Додати посилання на свою сторінку в заголовк сайту та у футері.
 * 
 * 
 */

/*
 * 2.
 * Створити клас-сервіс який віддає дані про вас
 * Створити інтерфейс для цього класу
 * Переписати клас модель сторінки на якій виводиться інформація про вас так, щоб він використовував цей сервіс
 * Зареєструвати сервіс в контейнері залежностей
 */