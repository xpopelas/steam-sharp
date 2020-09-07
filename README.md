# steam-sharp

steam-sharp is my little project written in C# to try out asynchronous programming, work with API libraries and work on GUI in the way of Windows Forms.

Because of the way it's made, it's only compatible on Windows platforms. I do not plan on working on this project any further as of right now, but there is a possibilty that I could work on it in some later future.

Application can be used to view many public Steam information directly through the app without opening browser/Steam client.

## Usage:

To use the application, just compile it as you would any other C# project and run the app.
Upon start, the application has 3 buttons, App Fetcher, Profile and Settings.

To start using the applications, you should first go into settings and provide at least the API key of the project.

### Settings
You can set the following things in settings:
  - API Key (you have to set this one, if you want to do anything with the app, as it fetches all of the data with SteamAPI)
  - Steam vanity profile URL (this one is used in Profile section of the app)
  - Preference on which data should be stored (such as API key, vanity URL and pre-loading of applications, which improves the performance and loading time)

### Profile
In Profile section, you can view basic information about your profile, such as:
  - Your current nickname
  - Your current status (online, offline, in-game etc.)
  - Your SteamID
  - List of your friends

Upon double clicking on any of your friends name, you are taken to their profile and you can see all of their public information.

### App Fetcher
In App Fetcher, you can find all apps, that are available in Steam (even non-game applications, such as game engines).
If you want to see more details about any of the Steam applications, just double click on it, and you'll be taken to another form, in which you can see the name, price (current and pre-discount), Metacritic score of the app, as well a button which will take you to the store website of that app.

License
--------
MIT
