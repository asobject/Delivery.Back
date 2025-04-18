﻿using BuildingBlocks.Exceptions;

namespace CompanyPoints.API.Services.App
{
    public static class ApplicationBuilderExtensionsService
    {
        public static void ConfigurePipeline(this WebApplication app)
        {
            //// Настройка Swagger
            //if (app.Environment.IsDevelopment())
            //{
            //    app.UseSwagger();
            //    app.UseSwaggerUI();
            //}


            // HTTPS, CORS, маршруты и аутентификация
           // app.UseWebSockets();
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseMiddleware<GlobalExceptionMiddleware>();

            app.MapControllers();
        }
    }
}
