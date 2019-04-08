using GraphQL.EntityFramework;

public class Query :
    EfObjectGraphType
{
    public Query(IEfGraphQLService efGraphQlService) :
        base(efGraphQlService)
    {
        AddQueryField(
            name: "customType",
            resolve: context =>
            {
                var dataContext = (MyDataContext) context.UserContext;
                return dataContext.CustomTypeEntities;
            });

        AddQueryField(
            name: "renameFields",
            resolve: context =>
            {
                var dataContext = (MyDataContext) context.UserContext;
                return dataContext.RenameFieldEntities;
            });

        AddQueryField(
            name: "skipLevel",
            resolve: context =>
            {
                var dataContext = (MyDataContext) context.UserContext;
                return dataContext.Level1Entities;
            }, graphType: typeof(SkipLevelGraph));

        AddQueryField(
            name: "manyChildren",
            resolve: context =>
            {
                var dataContext = (MyDataContext) context.UserContext;
                return dataContext.WithManyChildrenEntities;
            });

        AddQueryField(
            name: "level1Entities",
            resolve: context =>
            {
                var dataContext = (MyDataContext) context.UserContext;
                return dataContext.Level1Entities;
            },
            graphType: typeof(Level1Graph));

        AddQueryField(
            name: "withNullableEntities",
            resolve: context =>
            {
                var dataContext = (MyDataContext) context.UserContext;
                return dataContext.WithNullableEntities;
            });

        AddQueryField(
            name: "misNamed",
            resolve: context =>
            {
                var dataContext = (MyDataContext) context.UserContext;
                return dataContext.WithMisNamedQueryParentEntities;
            });

        AddQueryField(
            name: "parentEntities",
            resolve: context =>
            {
                var dataContext = (MyDataContext) context.UserContext;
                return dataContext.ParentEntities;
            });

        AddQueryField(
            name: "childEntities",
            resolve: context =>
            {
                var dataContext = (MyDataContext) context.UserContext;
                return dataContext.ChildEntities;
            });

        efGraphQlService.AddQueryConnectionField<ParentGraph, ParentEntity>(
            this,
            name: "parentEntitiesConnection",
            resolve: context =>
            {
                var dataContext = (MyDataContext) context.UserContext;
                return dataContext.ParentEntities;
            });

        efGraphQlService.AddQueryConnectionField<ChildGraph, ChildEntity>(
            this,
            name: "childEntitiesConnection",
            resolve: context =>
            {
                var dataContext = (MyDataContext) context.UserContext;
                return dataContext.ChildEntities;
            });

        AddQueryField(
            name: "parentEntitiesFiltered",
            resolve: context =>
            {
                var dataContext = (MyDataContext) context.UserContext;
                return dataContext.FilterParentEntities;
            });

        efGraphQlService.AddQueryConnectionField<FilterParentGraph, FilterParentEntity>(
            this,
            name: "parentEntitiesConnectionFiltered",
            resolve: context =>
            {
                var dataContext = (MyDataContext) context.UserContext;
                return dataContext.FilterParentEntities;
            });

        AddSingleField(
            name: "parentEntity",
            resolve: context =>
            {
                var dataContext = (MyDataContext) context.UserContext;
                return dataContext.ParentEntities;
            });
    }
}