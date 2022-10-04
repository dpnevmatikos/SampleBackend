# SampleBackend


1. Setup SQL server database through Docker:
```
sudo docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=s@mplepr0ject" -p 1433:1433 --name sql1-example --hostname sql1-example -d mcr.microsoft.com/mssql/server:2022-latest
```