// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

// Bicep documentation examples

@sys.description('The name of the resource.')
param name string

@sys.description('The location resources will be deployed.')
param location string = resourceGroup().location

resource server 'Microsoft.DBforMySQL/flexibleServers@2022-01-01' = {
  name: name
  location: location
  properties: {

  }
}
