using callList.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("CORSPolicy", builder =>
    {
        builder.AllowAnyMethod().AllowAnyHeader().WithOrigins("http://localhost:3000");
    });
});

// Add services to the container.
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

app.UseCors("CORSPolicy");

app.UseHttpsRedirection();

app.MapGet("/get-all-posts", async () => await PostsRepository.GetPostsAsync());

app.MapGet("/get-post-by-id/{Id}", async (int Id) =>
{
    Post postToReturn = await PostsRepository.GetPostByIdAsync(Id);
    if (postToReturn != null)
    {
        return Results.Ok(postToReturn);
    }
    else
    {
        return Results.BadRequest();
    }
});

app.MapPost("/create-post", async (Post postToCreate) =>
{
    bool createSuccessful = await PostsRepository.CreatePostAsync(postToCreate);
    if (createSuccessful)
    {
        return Results.Ok("created");
    }
    else
    {
        return Results.BadRequest();
    }
});

app.MapPut("/update-post", async (Post postToUpdate) =>
{
    bool updateSuccessful = await PostsRepository.UpdatePostAsync(postToUpdate);
    if (updateSuccessful)
    {
        return Results.Ok("update successful");
    }
    else
    {
        return Results.BadRequest();
    }
});

app.MapDelete("/delete-post-by-id/{Id}", async (int Id) =>
{
    bool deleteSuccessful = await PostsRepository.DeletePostAsync(Id);
    if (deleteSuccessful)
    {
        return Results.Ok("delete successful");
    }
    else
    {
        return Results.BadRequest();
    }
});




app.Run();

