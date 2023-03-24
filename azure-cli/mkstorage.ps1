az group create --name yeppa-resource-group --location northcentralus
az storage account create --name yeppastorage001 --resource-group yeppa-resource-group --location northcentralus --sku Standard_LRS --kind StorageV2

