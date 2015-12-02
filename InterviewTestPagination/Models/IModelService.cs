using System.Collections.Generic;

namespace InterviewTestPagination.Models {
    /// <summary>
    /// Model Service layer's main entry-point. 
    /// Should translate high-level commands and data structures into something that can be used by the data source layer.
    /// TODO: create appropriate method signatures
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IModelService<T> {

        IModelRepository<T> Repository { get; }

        IEnumerable<T> List(/* parameters */);

    }
}
