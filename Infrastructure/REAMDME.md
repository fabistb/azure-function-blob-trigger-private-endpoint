# Infrastructure
Run the following command to ensure that the example azure resources are set up.

```bash
az deployment group create --name <deployment name> --resource-group <your ressource group> --template-file resources.bicep --parameters @parameters.json
```

The following ressources are getting created:
- Storage Account
- Key Vault
- Virtual Network
- Private DNS zones
- Private endpoints
- Azure Function
- Azure App Service Plan

Further manual resource configuration shouldn't be required.