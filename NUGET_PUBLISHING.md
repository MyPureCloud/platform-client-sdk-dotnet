# Publishing NuGet Package to GitHub Package Registry

This project is configured to automatically publish to GitHub Package Registry on pushes to the `NET10` branch.

## Automatic Publishing

The workflow in `.github/workflows/publish-nuget.yml` will:
- Trigger on pushes to the `NET10` branch
- Build the project in Release configuration
- Pack and publish to GitHub Package Registry

**No manual action needed!** Just push your changes to the `NET10` branch and the workflow handles the rest.

## Using This Package

### 1. Create a GitHub Personal Access Token (PAT)

1. Go to https://github.com/settings/tokens
2. Click "Generate new token (classic)"
3. Select scopes: `read:packages`
4. Copy the token

### 2. Configure NuGet

You have two options:

#### Option A: Update `nuget.config` (Recommended for this project)

Replace placeholders in the root `nuget.config`:
```xml
<add key="Username" value="YOUR_GITHUB_USERNAME" />
<add key="ClearTextPassword" value="YOUR_GITHUB_TOKEN" />
```

#### Option B: Add source via dotnet CLI

```bash
dotnet nuget add source \
  --username YOUR_GITHUB_USERNAME \
  --password YOUR_GITHUB_TOKEN \
  --store-password-in-clear-text \
  --name github \
  "https://nuget.pkg.github.com/YOUR_GITHUB_USERNAME/index.json"
```

### 3. Add Package Reference

In your project file (`.csproj`):
```xml
<ItemGroup>
  <PackageReference Include="Infoveave.PureCloudPlatform.Client.V2" Version="1.0.0" />
</ItemGroup>
```

Or via dotnet CLI:
```bash
dotnet add package Infoveave.PureCloudPlatform.Client.V2 --version 1.0.0
```

## Version Management

Update the version in [build/src/PureCloudPlatform.Client.V2/PureCloudPlatform.Client.V2.csproj](build/src/PureCloudPlatform.Client.V2/PureCloudPlatform.Client.V2.csproj):

```xml
<Version>1.0.0</Version>
```

Each push will publish the version specified in the .csproj file.

## View Published Packages

Visit your GitHub Packages page:
- `https://github.com/YOUR_USERNAME/genesys-client/packages`

## Troubleshooting

### "401 Unauthorized" during publish
- Verify your GitHub token has `write:packages` scope
- Check that the token hasn't expired

### "The nuget source does not exist" error
- Ensure the GitHub source URL uses your actual username
- Verify credentials are correct in `nuget.config` or via CLI

### Package already exists error
- Update the version number in the `.csproj` file before pushing
- Set `--skip-duplicate` flag (already in workflow)
