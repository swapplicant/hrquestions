using System.Collections.Generic;

namespace InterviewTestPagination.Models.Todo {
    /// <summary>
    /// TODO: Implement methods that enable pagination
    /// </summary>
    public class TodoService : IModelService<Todo> {

        private readonly IModelRepository<Todo> _repository = new TodoRepository();

        public IModelRepository<Todo> Repository {
            get { return _repository; }
        }

        public IEnumerable<Todo> List(/* parameters */) {
            // invoke Datasource layer
            return Repository.All();
        }
    }
}
