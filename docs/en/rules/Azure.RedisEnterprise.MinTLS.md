---
severity: Critical
pillar: Security
category: SE:07 Encryption
resource: Azure Cache for Redis Enterprise
online version: https://azure.github.io/PSRule.Rules.Azure/en/rules/Azure.RedisEnterprise.MinTLS/
---

# Redis Cache minimum TLS version

## SYNOPSIS

Redis Cache should reject TLS versions older than 1.2.

## DESCRIPTION

The minimum version of TLS that Redis Cache accepts is configurable.
Older TLS versions are no longer considered secure by industry standards, such as PCI DSS.

Azure lets you disable outdated protocols and require connections to use a minimum of TLS 1.2.
By default, TLS 1.0, TLS 1.1, and TLS 1.2 is accepted.

## RECOMMENDATION

Consider configuring the minimum supported TLS version to be 1.2.
Support for TLS 1.0/ 1.1 version will be removed.

## EXAMPLES

### Configure with Azure template

To deploy caches that pass this rule:

- Set the `properties.minimumTlsVersion` property to `1.2`.

For example:

```json
{
  "type": "Microsoft.Cache/redisEnterprise",
  "apiVersion": "2022-01-01",
  "name": "[parameters('name')]",
  "location": "[parameters('location')]",
  "sku": {
    "name": "Enterprise_E10"
  },
  "properties": {
    "minimumTlsVersion": "1.2"
  }
}
```

### Configure with Bicep

To deploy caches that pass this rule:

- Set the `properties.minimumTlsVersion` property to `1.2`.

For example:

```bicep
resource cache 'Microsoft.Cache/redisEnterprise@2022-01-01' = {
  name: name
  location: location
  sku: {
    name: 'Enterprise_E10'
  }
  properties: {
    minimumTlsVersion: '1.2'
  }
}
```

### Configure with Azure CLI

To deploy caches that pass this rule:

- Use the `--set` parameter.

For example:

```bash
az redis update -n '<name>' -g '<resource_group>' --set minimumTlsVersion=1.2
```

### Configure with Azure PowerShell

To deploy caches that pass this rule:

- Use the `-MinimumTlsVersion` parameter.

For example:

```powershell
Set-AzRedisCache -Name '<name>' -MinimumTlsVersion '1.2'
```

## LINKS

- [SE:07 Encryption](https://learn.microsoft.com/azure/well-architected/security/encryption)
- [DP-3: Encrypt sensitive data in transit](https://learn.microsoft.com/security/benchmark/azure/baselines/azure-cache-for-redis-security-baseline#dp-3-encrypt-sensitive-data-in-transit)
- [Remove TLS 1.0 and 1.1 from use with Azure Cache for Redis](https://learn.microsoft.com/azure/azure-cache-for-redis/cache-remove-tls-10-11)
- [Configure Azure Cache for Redis settings](https://learn.microsoft.com/azure/azure-cache-for-redis/cache-configure#access-ports)
- [Preparing for TLS 1.2 in Microsoft Azure](https://azure.microsoft.com/updates/azuretls12/)
- [Azure deployment reference](https://learn.microsoft.com/azure/templates/microsoft.cache/redisenterprise)
