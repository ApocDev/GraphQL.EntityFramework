using GraphQL.EntityFramework;

public class RenameFieldGraph :
    EfObjectGraphType<RenameFieldEntity>
{
    public RenameFieldGraph(IEfGraphQLService graphQlService) :
        base(graphQlService)
    {
        Field(x => x.Id);
        AddNavigationField(
            name: "child",
            resolve: context => context.Source.Child);
    }
}