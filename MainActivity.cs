using Android.App;
using Android.Widget;
using Android.OS;

namespace Contacts_Read
{
    [Activity(Label = "Contacts_Read", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            var contactAdapter = new ContactAdapter(this);
            var contactsListView = FindViewById<ListView>(Resource.Id.ContactsListView);
            contactsListView.Adapter = contactAdapter;

        }
    }
}

