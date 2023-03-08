# azure-function-blob-trigger-private-endpoint
Example repository to test the behavior of an azure function blob trigger with a private endpoint.
The example should highlight if the function host crashes if a blob trigger is deployed and the blob storage isn't public available.

## Repo structure
### Infrastrucuture
Contains the infrastructure script for an easy example environment setup.

### BlobTriggerIsolatedFunction
Contains a minimal example function.