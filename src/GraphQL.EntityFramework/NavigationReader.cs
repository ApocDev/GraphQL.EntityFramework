using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

static class NavigationReader
{
    public static Dictionary<Type, List<Navigation>> GetNavigationProperties(IModel model)
    {
        return GetEntityTypes(model)
            .ToDictionary(x => x.ClrType, GetNavigations);
    }

    private static IEnumerable<IEntityType> GetEntityTypes(IModel model)
    {
        return model
            .GetEntityTypes();
    }

    static List<Navigation> GetNavigations(IEntityType entity)
    {
        var navigations = entity.GetNavigations();
        return navigations
            .Select(x => new Navigation(x.Name, GetNavigationType(x)))
            .ToList();
    }

    static Type GetNavigationType(INavigation navigation)
    {
        var navigationType = navigation.ClrType;
        var collectionType = navigationType.GetInterfaces()
            .SingleOrDefault(x =>
                x.IsGenericType &&
                x.GetGenericTypeDefinition() == typeof(ICollection<>));
        if (collectionType == null)
        {
            return navigationType;
        }

        return collectionType.GetGenericArguments().Single();
    }
}