using GraphQL.EntityFramework;

public class Entity1Graph :
    EfObjectGraphType<Entity1>
{
    public Entity1Graph(IEfGraphQLService graphQlService) :
        base(graphQlService)
    {
        Field(x => x.Id);
        Field(x => x.Property);
    }
}