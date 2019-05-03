using GraphQL.EntityFramework;

public class MultiContextQuery :
    QueryGraphType
{
    public MultiContextQuery(IEfGraphQLService efGraphQlService) :
        base(efGraphQlService)
    {
        AddSingleField(
            name: "entity1",
            resolve: context =>
            {
                var userContext = (UserContext) context.UserContext;
                return userContext.DbContext1.Entities;
            });
        AddSingleField(
            name: "entity2",
            resolve: context =>
            {
                var userContext = (UserContext) context.UserContext;
                return userContext.DbContext2.Entities;
            });
    }
}