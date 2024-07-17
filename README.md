# SeriLogSimple
SeriLogSimple is a project developed with .NET 6, utilizing the SeriLog library for logging operations. The project is configured to manage error and information logs separately in dedicated log files.

## Installation
To set up the project on your local development environment, follow these steps:

1.Clone the Repository
```bash
git clone https://github.com/username/SeriLogSimple.git
cd SeriLogSimple
```
2.Install Dependencies
```bash
dotnet restore
```
3.Configure Logging
```Update the SeriLog configuration in appsettings.json as follows:
"Serilog": {
  "Using": [ "Serilog.Sinks.File" ],
  "WriteTo": [
    {
      "Name": "File",
      "Args": {
        "path": "logs/error.log",
        "rollingInterval": "Day",
        "restrictedToMinimumLevel": "Error"
      }
    },
    {
      "Name": "File",
      "Args": {
        "path": "logs/info.log",
        "rollingInterval": "Day",
        "restrictedToMinimumLevel": "Information"
      }
    }
  ]
}
```
## Usage
The project handles logging operations in separate methods, writing error logs to "logs/error.log" and information logs to "logs/info.log". It logs only Error level logs to the error log file and Information level logs to the information log file.

## Contributing
This project is open source, and contributions are welcome. You can contribute by opening a pull request or creating an issue.

## License
This project is licensed under the MIT License. For more details, see the LICENSE file.
