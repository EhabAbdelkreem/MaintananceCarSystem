﻿
namespace serenity_carsystem.Administration;

using Serenity.Abstractions;
using Serenity.ComponentModel;
using Serenity.Web;
using serenity_carsystem.Administration.Repositories;
using System;
using System.Collections.Generic;

[DataScript("Administration.PermissionKeys", Permission = PermissionKeys.Security)]
public class PermissionKeysDataScript : DataScript<IEnumerable<string>>
{
    private readonly ITwoLevelCache cache;
    private readonly ITypeSource typeSource;

    public PermissionKeysDataScript(ITwoLevelCache cache, ITypeSource typeSource)
    {
        GroupKey = RoleRow.Fields.GenerationKey;
        this.cache = cache ?? throw new ArgumentNullException(nameof(cache));
        this.typeSource = typeSource ?? throw new ArgumentNullException(nameof(typeSource));
    }

    protected override IEnumerable<string> GetData()
    {
        return UserPermissionRepository.ListPermissionKeys(cache, typeSource);
    }
}