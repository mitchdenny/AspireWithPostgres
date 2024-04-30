# AspireWithPostgres Repro

# AZD Version
```dotnetcli
$ azd version
azd version 1.8.2-daily.3745256 (commit 14600c7a54edac4f54397413f8638431f5c16327)
```

# Aspire Version

```dotnetcli
dotnet workload list

Installed Workload Id      Manifest Version                     Installation Source
--------------------------------------------------------------------------------------------------------------------------------
android                    34.0.106/8.0.100                     SDK 8.0.300-preview.24203, VS 17.10.34818.151
aspire                     8.0.0-preview.7.24230.4/8.0.100      SDK 8.0.300-preview.24203, VS 17.11.34828.26, VS 17.10.34818.151
ios                        17.2.8062/8.0.100                    SDK 8.0.300-preview.24203, VS 17.10.34818.151
maccatalyst                17.2.8062/8.0.100                    SDK 8.0.300-preview.24203, VS 17.10.34818.151
maui-windows               8.0.21/8.0.100                       SDK 8.0.300-preview.24203, VS 17.10.34818.151

Use `dotnet workload search` to find additional workloads to install.
```

# Error

```
Deploying services (azd deploy)

  (x) Failed: Deploying service apiservice

ERROR: failed deploying service 'apiservice': failing invoking action 'deploy', failed executing template file: template: containerApp.tmpl.yaml:21:19: executing "containerApp.tmpl.yaml" at <secretOutput "SERVICE_BINDING_PGSQLKV_ENDPOINT" "connectionString">: error calling secretOutput: the value for SERVICE_BINDING_PGSQLKV_ENDPOINT was not found or is empty

ERROR: error executing step command 'deploy --all': failed deploying service 'apiservice': failing invoking action 'deploy', failed executing template file: template: containerApp.tmpl.yaml:21:19: executing "containerApp.tmpl.yaml" at <secretOutput "SERVICE_BINDING_PGSQLKV_ENDPOINT" "connectionString">: error calling secretOutput: the value for SERVICE_BINDING_PGSQLKV_ENDPOINT was not found or is empty
```