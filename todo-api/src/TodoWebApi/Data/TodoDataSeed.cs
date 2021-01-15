using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoWebApi.Core;
using TodoWebApi.Core.Models;

namespace TodoWebApi.Data
{
    public static class TodoDataSeed
    {

        public static async Task InitDataAsync(IUnitOfWork unitOfWork)
        {

            Todo buyFood = new Todo
            {
                CreatedOn = DateTime.Now.AddDays(-1),
                Title = "Buy food"
            };
            await unitOfWork.Todo.Add(buyFood);

            Todo washClothes = new Todo
            {
                CreatedOn = DateTime.Now.AddDays(-2),
                Title = "Wash clothes"
            };
            await unitOfWork.Todo.Add(washClothes);

            Todo orderVitamins = new Todo
            {
                CreatedOn = DateTime.Now.AddDays(-3),
                CompletedOn = DateTime.Now.AddDays(-1),
                Title = "Order vitamins"
            };
            await unitOfWork.Todo.Add(orderVitamins);

            await unitOfWork.CommitAsync();

        }

    }
}
