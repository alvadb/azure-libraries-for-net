// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Sql.Fluent.SqlElasticPools.SqlElasticPoolsCreatable
{
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using Microsoft.Azure.Management.Sql.Fluent.SqlElasticPool.Definition;
    using Microsoft.Azure.Management.Sql.Fluent;

    /// <summary>
    /// Entry point to SQL ElasticPool management API, which already have the SQLServer specified.
    /// </summary>
    public interface ISqlElasticPoolsCreatable  :
        Microsoft.Azure.Management.Sql.Fluent.ISqlElasticPools
    {
        Microsoft.Azure.Management.Sql.Fluent.SqlElasticPool.Definition.IBlank DefinedWithSqlServer(string resourceGroupName, string sqlServerName, string elasticPoolName, Region region);
    }
}