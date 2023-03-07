# Infrastructure
Run the following command to ensure that the example azure ressources are set up.

```bash
az deployment group create --name <deployment name> --resource-group <your ressource group> --template-file resources.bicep --parameters @parameters.json
```