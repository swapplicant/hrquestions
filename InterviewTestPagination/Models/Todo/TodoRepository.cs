using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewTestPagination.Models.Todo {

    /// <summary>
    /// No need to use an actual persistent datasource. 
    /// All operations can be mocked in-memory as long as they are consistent with the chosen datasource implementation 
    /// (e.g. dont create new model instances when executing a search 'query', etc).
    /// </summary>
    public class TodoRepository : IModelRepository<Todo> {

        /// <summary>
        /// Example in-memory model datasource 'indexed' by id.
        /// </summary>
        private static readonly IDictionary<long, Todo> Registry = new Dictionary<long, Todo>();

        static TodoRepository() {
            var startDate = DateTime.Today;

            // initializing datasource
            for (var i = 1; i <= 55; i++) {
                var createdDate = startDate.AddDays(i);
                Registry[i] = new Todo(id: i, task: "Dont forget to do " + i, createdDate: createdDate);
            }
        }

        public IEnumerable<Todo> All() {
            return Registry.Values.OrderByDescending(t => t.CreatedDate);
        }

    }
}
