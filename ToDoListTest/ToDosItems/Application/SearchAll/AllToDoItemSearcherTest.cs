using System.Collections.Generic;
using System.Threading.Tasks;
using TodoList.ToDosItems.Application;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TodoList.ToDosItems.Application.Create;
using TodoList.ToDosItems.Application.SearchAll;
using TodoList.ToDosItems.Domain;
using TodoList.ToDosItems.Infraestructure.Persistence;
using TodoList.ToDosItems.Shared.Infraestrucutre.Persistence.EntityFramework;

namespace ToDoListTest.ToDosItems.Application.SearchAll
{
    [TestClass]
    public class AllToDoItemSearcherTest
    {
        [TestMethod]
        public async Task AllToDoSearch()
        {
            var repository = new MySqlToDoItemRepository(new TodoListContext());
            var useCase = new ToDoItemSearcher(repository);
            var result = await useCase.SearchAllToDoItems();
            Assert.IsNotNull(result); 
        }
    }
}