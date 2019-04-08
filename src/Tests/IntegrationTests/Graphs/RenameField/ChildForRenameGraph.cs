using GraphQL.EntityFramework;

public class ChildForRenameGraph :
    EfObjectGraphType<ChildForRenameEntity>
{
    public ChildForRenameGraph(IEfGraphQLService graphQlService) :
        base(graphQlService)
    {
        Field(x => x.Id);
    }
}