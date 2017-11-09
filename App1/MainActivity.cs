using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.V7.AppCompat;

using Parse;

namespace App1
{
    [Activity(Label = "App1", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Back4App Initialization
            ParseClient.Initialize(new ParseClient.Configuration
            {
                ApplicationId = GetString(Resource.String.back4app_app_id),
                WindowsKey = GetString(Resource.String.back4app_dotnet_key),
                Server = "https://parseapi.back4app.com"
            });
            
            // Set our view from the "Main" layout resource
            SetContentView(Resource.Layout.Main);

            // Save the current Installation to Back4App
            ParseInstallation.CurrentInstallation.SaveAsync();
        }
    }
}

