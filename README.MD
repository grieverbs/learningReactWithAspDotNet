# Learning ASP.NET with ReactJS

I figured learning C# and .NET as more of a webservice would be better. https://learn.microsoft.com/en-us/visualstudio/javascript/tutorial-asp-net-core-with-react?view=vs-2022

# Hit the prerequisites

- Visual Studio Community Edition with ASP.NET and web development workload.
- `curl -qL https://www.npmjs.com/install.sh | sh`
- Node LTS (Using 20.9.0 LTS)

## Test Node

```bash
cd ClientApp
npm install
npm start (more info in ClientApp/README.md)
```

## Running the webservice F5

You might see an error with missing CMD npm. Probably because NODE was installed after Visual Studio is opened and the environment hasn't been reloaded for the app. Just restart it.

## C# resources
https://learn.microsoft.com/en-us/dotnet/csharp/

## Playing with Github's emojis
https://api.github.com/emojis