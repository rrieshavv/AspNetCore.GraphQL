﻿using Api.Database;

namespace Api.GraphQL
{
    public class Query
    {
        public Task<List<Book>> GetBooks([Service] Repository repository) => repository.GetBooksAsync();


    }
}
