using GraphQL.EntityFramework;

public class Entity2Graph :
    EfObjectGraphType<Entity2>
{
    public Entity2Graph(IEfGraphQLService graphQlService) :
        base(graphQlService)
    {
        Field(x => x.Id);
        Field(x => x.Property);
    }
}