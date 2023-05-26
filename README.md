#  ========================
#  UnitOfWork
#  ========================

## Shortcuts
PS: function prompt {">>:"}

### Installs 
	Before scaffolding, you'll need to install either the PMC tools, which work on Visual Studio only, or the .NET CLI tools, which 	across all platforms supported by .NET.
	Install the NuGet package for Microsoft.EntityFrameworkCore.Design in the project you are scaffolding to.
	Install the NuGet package for the database provider that targets the database schema you want to scaffold from.
	Link: https://learn.microsoft.com/en-us/ef/core/managing-schemas/scaffolding/?tabs=dotnet-core-cli
	
	 
	dotnet add package 'Microsoft.EntityFrameworkCore.SqlServer
	Install-Package Microsoft.EntityFrameworkCore
	Install-Package Microsoft.EntityFrameworkCore.Design
	Install-Package Microsoft.VisualStudio.Web.CodeGeneration.Design



--------------
# TOPICS ##
-------------- 
## Scafolding Entities

### Scafolding - using connString in configurationfile
dotnet ef dbcontext scaffold "Name=ConnectionStrings:CatalogoDB" Microsoft.EntityFrameworkCore.SqlServer
dotnet ef dbcontext scaffold "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Chinook" Microsoft.EntityFrameworkCore.SqlServer

### Scafolding - options 
dotnet ef dbcontext scaffold ... --table Artist --table Album
dotnet ef dbcontext scaffold ... --schema Customer --schema Contractor
dotnet ef dbcontext scaffold ... --table Customer.Purchases --table Contractor.Accounts --table Contractor.Contracts

### Scafolding - Preserving database names
--use-database-names

### Scafolding - Use mapping attributes (aka Data Annotations)
Entity types are configured using the ModelBuilder API in OnModelCreating by default. Specify -DataAnnotations (PMC) or --data-annotations (.NET Core CLI) to instead use mapping attributes when possible.

### Scafolding - DbContext name
	The scaffolded DbContext class name will be the name of the database suffixed with Context by default. To specify a different 	one, use -Context in PMC and --context in the .NET Core CLI.
	--context


### Scafolding - Target directories and namespaces
	--context-dir
	dotnet ef dbcontext scaffold ... --context-dir Data --output-dir Models
	--context-namespace
	dotnet ef dbcontext scaffold ... --namespace Your.Namespace --context-namespace Your.DbContext.Namespace

### Scafolding - Ours  
dotnet ef dbcontext scaffold "Name=ConnectionStrings:CatalogoDB" Microsoft.EntityFrameworkCore.SqlServer --context-dir Data --output-dir Models

[TIP] By default, the EF commands will not overwrite any existing code to protect against accidental code loss. The -Force (Visual Studio PMC) or --force (.NET CLI)

dotnet ef dbcontext scaffold "Name=ConnectionStrings:CatalogoDB" Microsoft.EntityFrameworkCore.SqlServer --context-dir Data --output-dir Models --force

## Scafolding Controllers

Add New Scaffolded Item >> API >> API Controller with actions, using Entity Framework


## About UnitOfWork and Repositories
https://learn.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application















----------------------------
### Future Improvments
----------------------------
### [1] - ConnectionStrings using Azure Key Vault 
- https://learn.microsoft.com/en-us/ef/core/managing-schemas/scaffolding/?tabs=dotnet-core-cli  
- (https://learn.microsoft.com/en-us/azure/key-vault/keys/quick-create-net)
### [2] - Explore other controller types, topic: Scafolding Controllers

### [3] - 

### [4] - 

### [5] - 

--------------
#References
--------------

### Entity Framework Core: 
	https://learn.microsoft.com/en-us/ef/core/

### Scaffolding (Reverse Engineering)
	EF Core can also reverse engineer a model from an existing database.
	https://learn.microsoft.com/en-us/ef/core/managing-schemas/scaffolding/?tabs=dotnet-core-cli